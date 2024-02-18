using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Baidu.Push.Interceptors
{
    using SKIT.FlurlHttpClient.Internal;

    internal class BaiduPushRequestSigningInterceptor : HttpInterceptor
    {
        private const string QUERY_NAME_APIKEY = "apikey";
        private const string QUERY_NAME_TIMESTAMP = "timestamp";
        private const string QUERY_NAME_EXPIRES = "expires";
        private const string QUERY_NAME_SIGN = "sign";

        private readonly string _apiKey;
        private readonly string _secretKey;

        public BaiduPushRequestSigningInterceptor(string apiKey, string apiSecretKey)
        {
            _apiKey = apiKey;
            _secretKey = apiSecretKey;
        }

        public override async Task BeforeCallAsync(HttpInterceptorContext context, CancellationToken cancellationToken = default)
        {
            if (context is null) throw new ArgumentNullException(nameof(context));
            if (context.FlurlCall.Completed) throw new BaiduPushException("Failed to sign request. This interceptor must be called before request completed.");

            // 生成通用参数
            string method = context.FlurlCall.HttpRequestMessage.Method.ToString().ToUpper();
            string url = context.FlurlCall.HttpRequestMessage.RequestUri?.ToString()?.Split('?')?.FirstOrDefault() ?? string.Empty;
            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string expires = DateTimeOffset.Now.AddMinutes(5).ToLocalTime().ToUnixTimeSeconds().ToString();
            string? queryString = context.FlurlCall.HttpRequestMessage.RequestUri?.Query;

            // 组合 GET+POST 参数
            if (context.FlurlCall.HttpRequestMessage.Content is not null)
            {
                if (!string.IsNullOrEmpty(queryString?.TrimStart('?')))
                    queryString += "&";
                else
                    queryString = "?";

                queryString += await _AsyncEx.RunTaskWithCancellationTokenAsync(context.FlurlCall.HttpRequestMessage.Content.ReadAsStringAsync(), cancellationToken).ConfigureAwait(false);
            }

            // 对参数按字典序升序排序
            var queryParams = new QueryParamCollection(queryString);
            queryParams.AddOrReplace(QUERY_NAME_APIKEY, _apiKey);
            queryParams.AddOrReplace(QUERY_NAME_TIMESTAMP, timestamp);
            queryParams.AddOrReplace(QUERY_NAME_EXPIRES, expires);
            queryParams.Remove(QUERY_NAME_SIGN);
            var sortedQueryParams = queryParams
                .OrderBy(e => e.Name, StringComparer.Ordinal)
                .Where(e => e.Value is not null && !string.IsNullOrEmpty(e.Value.ToString()))
                .Select(e => $"{e.Name}={e.Value}");
            queryString = string.Join(string.Empty, sortedQueryParams);

            // 生成请求签名
            string signData = Utilities.QuirksUrlEncoder.Encode($"{method}{url}{queryString}{_secretKey}");
            string sign = Utilities.MD5Utility.Hash(signData).Value!.ToLower();

            // 根据 GET/POST 请求，决定追加签名的方式
            if (method == "GET")
            {
                context.FlurlCall.Request.SetQueryParam(QUERY_NAME_APIKEY, _apiKey);
                context.FlurlCall.Request.SetQueryParam(QUERY_NAME_TIMESTAMP, timestamp);
                context.FlurlCall.Request.SetQueryParam(QUERY_NAME_EXPIRES, expires);
                context.FlurlCall.Request.SetQueryParam(QUERY_NAME_SIGN, sign);
            }
            else if (method == "POST")
            {
                queryParams.Add(QUERY_NAME_SIGN, sign);
                context.FlurlCall.HttpRequestMessage.Content = new StringContent(queryParams.ToString(), Encoding.UTF8, MimeTypes.FormUrlEncoded);
            }
            else
            {
                throw new BaiduPushException($"Failed to sign request. Unsupported HTTP method: \"{method}\".");
            }
        }
    }
}
