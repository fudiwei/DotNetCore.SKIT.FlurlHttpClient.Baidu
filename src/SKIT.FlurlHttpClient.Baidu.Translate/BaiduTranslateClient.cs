using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Baidu.Translate
{
    /// <summary>
    /// 一个百度翻译开放平台 API HTTP 客户端。
    /// </summary>
    public class BaiduTranslateClient : CommonClientBase, ICommonClient
    {
        /// <summary>
        /// 获取当前客户端使用的百度翻译开放平台凭证。
        /// </summary>
        public Settings.Credentials Credentials { get; }

        /// <summary>
        /// 用指定的配置项初始化 <see cref="BaiduTranslateClient"/> 类的新实例。
        /// </summary>
        /// <param name="options">配置项。</param>
        public BaiduTranslateClient(BaiduTranslateClientOptions options)
            : base()
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            Credentials = new Settings.Credentials(options);

            FlurlClient.BaseUrl = options.Endpoint ?? BaiduTranslateEndpoints.DEFAULT;
            FlurlClient.WithTimeout(TimeSpan.FromMilliseconds(options.Timeout));
        }

        /// <summary>
        /// 用指定的百度翻译 AppId 和 AppSecret 初始化 <see cref="BaiduTranslateClient"/> 类的新实例。
        /// </summary>
        /// <param name="appId">百度翻译 AppId。</param>
        /// <param name="appSecret">百度翻译 AppSecret。</param>
        public BaiduTranslateClient(string appId, string appSecret)
            : this(new BaiduTranslateClientOptions() { AppId = appId, AppSecret = appSecret })
        {
        }

        /// <summary>
        /// 使用当前客户端生成一个新的 <see cref="IFlurlRequest"/> 对象。
        /// </summary>
        /// <param name="request"></param>
        /// <param name="method"></param>
        /// <param name="urlSegments"></param>
        /// <returns></returns>
        public IFlurlRequest CreateRequest(BaiduTranslateRequest request, HttpMethod method, params object[] urlSegments)
        {
            IFlurlRequest flurlRequest = FlurlClient.Request(urlSegments).WithVerb(method);

            if (request.Timeout != null)
            {
                flurlRequest.WithTimeout(TimeSpan.FromMilliseconds(request.Timeout.Value));
            }

            if (request.AppId == null)
            {
                request.AppId = Credentials.AppId;
            }

            if (request.Salt == null)
            {
                request.Salt = Guid.NewGuid().ToString("N");
            }

            if (request.Timestamp == null)
            {
                request.Timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds();
            }

            if (request.Signature == null)
            {
                request.Signature = request.GenerateSignature(Credentials);
            }

            return flurlRequest;
        }

        /// <summary>
        /// 异步发起请求。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="flurlRequest"></param>
        /// <param name="httpContent"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<T> SendRequestAsync<T>(IFlurlRequest flurlRequest, HttpContent? httpContent = null, CancellationToken cancellationToken = default)
            where T : BaiduTranslateResponse, new()
        {
            if (flurlRequest == null) throw new ArgumentNullException(nameof(flurlRequest));

            try
            {
                using IFlurlResponse flurlResponse = await base.SendRequestAsync(flurlRequest, httpContent, cancellationToken);
                return await WrapResponseWithJsonAsync<T>(flurlResponse, cancellationToken);
            }
            catch (FlurlHttpTimeoutException ex)
            {
                throw new Exceptions.BaiduTranslateRequestTimeoutException(ex.Message, ex);
            }
            catch (FlurlHttpException ex)
            {
                throw new BaiduTranslateException(ex.Message, ex);
            }
        }

        /// <summary>
        /// 异步发起请求。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="flurlRequest"></param>
        /// <param name="data"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<T> SendRequestWithJsonAsync<T>(IFlurlRequest flurlRequest, object? data = null, CancellationToken cancellationToken = default)
            where T : BaiduTranslateResponse, new()
        {
            if (flurlRequest == null) throw new ArgumentNullException(nameof(flurlRequest));

            try
            {
                bool isSimpleRequest = data == null ||
                    flurlRequest.Verb == HttpMethod.Get ||
                    flurlRequest.Verb == HttpMethod.Head ||
                    flurlRequest.Verb == HttpMethod.Options;
                using IFlurlResponse flurlResponse = isSimpleRequest ?
                    await base.SendRequestAsync(flurlRequest, null, cancellationToken) :
                    await base.SendRequestWithJsonAsync(flurlRequest, data, cancellationToken);
                return await WrapResponseWithJsonAsync<T>(flurlResponse, cancellationToken);
            }
            catch (FlurlHttpTimeoutException ex)
            {
                throw new Exceptions.BaiduTranslateRequestTimeoutException(ex.Message, ex);
            }
            catch (FlurlHttpException ex)
            {
                throw new BaiduTranslateException(ex.Message, ex);
            }
        }

        /// <summary>
        /// 异步发起请求。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="flurlRequest"></param>
        /// <param name="formdata"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<T> SendRequestWithFormUrlEncodedAsync<T>(IFlurlRequest flurlRequest, IDictionary<string, IConvertible?>? formdata = null, CancellationToken cancellationToken = default)
            where T : BaiduTranslateResponse, new()
        {
            if (flurlRequest == null) throw new ArgumentNullException(nameof(flurlRequest));

            HttpContent? httpContent = null;
            if (formdata != null)
            {
                if (!flurlRequest.Headers.Contains(Constants.HttpHeaders.ContentType))
                {
                    flurlRequest.WithHeader(Constants.HttpHeaders.ContentType, "application/x-www-form-urlencoded;charset=utf-8");
                }

                IDictionary<string, string> tmpDict = formdata
                    .Where(e => e.Value != null)
                    .ToDictionary(k => k.Key, v => v.Value!.ToString()!);
                httpContent = new FormUrlEncodedContent(tmpDict);
            }

            try
            {
                using IFlurlResponse flurlResponse = await base.SendRequestAsync(flurlRequest, httpContent, cancellationToken).ConfigureAwait(false);
                return await WrapResponseWithJsonAsync<T>(flurlResponse).ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                throw new BaiduTranslateException(ex.Message, ex);
            }
        }

        /// <summary>
        /// 异步发起请求。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="flurlRequest"></param>
        /// <param name="data"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<T> SendRequestWithFormUrlEncodedAsync<T>(IFlurlRequest flurlRequest, object? data = null, CancellationToken cancellationToken = default)
            where T : BaiduTranslateResponse, new()
        {
            bool isSimpleRequest = data == null ||
                flurlRequest.Verb == HttpMethod.Get ||
                flurlRequest.Verb == HttpMethod.Head ||
                flurlRequest.Verb == HttpMethod.Options;
            if (isSimpleRequest)
            {
                return await SendRequestAsync<T>(flurlRequest, null, cancellationToken);
            }
            else
            {
                string tmpJson = JsonSerializer.Serialize(data);
                IDictionary<string, IConvertible?> formdata = new FlurlNewtonsoftJsonSerializer()
                    .Deserialize<IDictionary<string, string?>>(tmpJson)
                    .ToDictionary(k => k.Key, v => v.Value as IConvertible);
                return await SendRequestWithFormUrlEncodedAsync<T>(flurlRequest, formdata, cancellationToken);
            }
        }
    }
}
