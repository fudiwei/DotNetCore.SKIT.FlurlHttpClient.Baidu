using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.Baidu.Push
{
    /// <summary>
    /// 用于构造 <see cref="BaiduPushClient"/> 实例的构造器。
    /// </summary>
    public partial class BaiduPushClientBuilder : ICommonClientBuilder<BaiduPushClient>
    {
        private readonly BaiduPushClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;
        private HttpClient? _httpClient;
        private bool? _disposeClient;

        private BaiduPushClientBuilder(BaiduPushClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<BaiduPushClient> ICommonClientBuilder<BaiduPushClient>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<BaiduPushClient> ICommonClientBuilder<BaiduPushClient>.UseInterceptor(HttpInterceptor interceptor)
        {
            return UseInterceptor(interceptor);
        }

        ICommonClientBuilder<BaiduPushClient> ICommonClientBuilder<BaiduPushClient>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            return UseHttpClient(httpClient, disposeClient);
        }

        public BaiduPushClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public BaiduPushClientBuilder UseInterceptor(HttpInterceptor interceptor)
        {
            if (interceptor is null) throw new ArgumentNullException(nameof(interceptor));

            _interceptors.Add(interceptor);
            return this;
        }

        public BaiduPushClientBuilder UseHttpClient(HttpClient httpClient, bool disposeClient = true)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _disposeClient = disposeClient;
            return this;
        }

        public BaiduPushClient Build()
        {
            BaiduPushClient client = _disposeClient.HasValue
                ? new BaiduPushClient(_options, _httpClient, _disposeClient.Value)
                : new BaiduPushClient(_options, _httpClient);

            foreach (Action<CommonClientSettings> configure in _configures)
            {
                client.Configure(configure);
            }

            foreach (HttpInterceptor interceptor in _interceptors)
            {
                client.Interceptors.Add(interceptor);
            }

            return client;
        }
    }

    partial class BaiduPushClientBuilder
    {
        public static BaiduPushClientBuilder Create(BaiduPushClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new BaiduPushClientBuilder(options);
        }
    }
}
