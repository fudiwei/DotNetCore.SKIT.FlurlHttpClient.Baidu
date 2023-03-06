using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Baidu.Push.Interceptors
{
    internal class BaiduPushRequestSignatureInterceptor : FlurlHttpCallInterceptor
    {
        private const string QUERY_NAME_APIKEY = "apikey";
        private const string QUERY_NAME_TIMESTAMP = "timestamp";
        private const string QUERY_NAME_EXPIRES = "expires";
        private const string QUERY_NAME_SIGN = "sign";

        private readonly string _apiKey;
        private readonly string _secretKey;

        public BaiduPushRequestSignatureInterceptor(string apiKey, string apiSecretKey)
        {
            _apiKey = apiKey;
            _secretKey = apiSecretKey;
        }

        public override async Task BeforeCallAsync(FlurlCall flurlCall)
        {
            if (flurlCall == null) throw new ArgumentNullException(nameof(flurlCall));
            if (flurlCall.Completed) throw new Exceptions.BaiduPushRequestSignatureException("This interceptor must be called before request completed.");

            // 生成通用参数
            string method = flurlCall.HttpRequestMessage.Method.ToString().ToUpper();
            string url = flurlCall.HttpRequestMessage.RequestUri?.ToString()?.Split('?')?.FirstOrDefault() ?? string.Empty;
            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string expires = DateTimeOffset.Now.AddMinutes(5).ToLocalTime().ToUnixTimeSeconds().ToString();
            string? queryString = flurlCall.HttpRequestMessage.RequestUri?.Query;

            // 组合 GET+POST 参数
            if (flurlCall.HttpRequestMessage.Content is FormUrlEncodedContent ||
                flurlCall.HttpRequestMessage.Content is StringContent ||
                !string.IsNullOrEmpty(flurlCall.RequestBody))
            {
                queryString = await flurlCall.HttpRequestMessage.Content.ReadAsStringAsync();

                if (!string.IsNullOrEmpty(queryString?.TrimStart('?')))
                    queryString += "&";
                else
                    queryString = "?";

                queryString += flurlCall.RequestBody;
            }

            // 对参数按字典序升序排序
            var queryParams = new QueryParamCollection(queryString);
            queryParams.AddOrReplace(QUERY_NAME_APIKEY, _apiKey);
            queryParams.AddOrReplace(QUERY_NAME_TIMESTAMP, timestamp);
            queryParams.AddOrReplace(QUERY_NAME_EXPIRES, expires);
            queryParams.Remove(QUERY_NAME_SIGN);
            var sortedQueryParams = queryParams
                .OrderBy(e => e.Name, StringComparer.Ordinal)
                .Where(e => e.Value != null && !string.IsNullOrEmpty(e.Value.ToString()))
                .Select(e => $"{e.Name}={e.Value}");
            queryString = string.Join(string.Empty, sortedQueryParams);

            // 生成请求签名
            string msgText = Utilities.UrlEncoder.Encode($"{method}{url}{queryString}{_secretKey}");
            string signText = Utilities.MD5Utility.Hash(msgText).ToLower();

            // 根据 GET/POST 请求，决定追加签名的方式
            if (flurlCall.HttpRequestMessage.Method == HttpMethod.Get)
            {
                flurlCall.Request.RemoveQueryParams(QUERY_NAME_APIKEY, QUERY_NAME_TIMESTAMP, QUERY_NAME_EXPIRES, QUERY_NAME_SIGN);
                flurlCall.Request.SetQueryParam(QUERY_NAME_APIKEY, _apiKey);
                flurlCall.Request.SetQueryParam(QUERY_NAME_TIMESTAMP, timestamp);
                flurlCall.Request.SetQueryParam(QUERY_NAME_EXPIRES, expires);
                flurlCall.Request.SetQueryParam(QUERY_NAME_SIGN, signText);
            }
            else if (flurlCall.HttpRequestMessage.Method == HttpMethod.Post)
            {
                queryParams.Add(QUERY_NAME_SIGN, signText);
                flurlCall.HttpRequestMessage.Content = new StringContent(queryParams.ToString(), Encoding.UTF8, "application/x-www-form-urlencoded");
            }
            else
            {
                throw new Exceptions.BaiduPushRequestSignatureException($"Not supported HTTP method: \"{method}\".");
            }
        }
    }
}
