using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi
{
    /// <summary>
    /// 用于构造 <see cref="BaiduSmartAppOpenApiClient"/> 实例的构造器。
    /// </summary>
    public partial class BaiduSmartAppOpenApiClientBuilder : ICommonClientBuilder<BaiduSmartAppOpenApiClient>
    {
        private readonly BaiduSmartAppOpenApiClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;
        private HttpClient? _httpClient;
        private bool? _disposeClient;

        private BaiduSmartAppOpenApiClientBuilder(BaiduSmartAppOpenApiClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<BaiduSmartAppOpenApiClient> ICommonClientBuilder<BaiduSmartAppOpenApiClient>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<BaiduSmartAppOpenApiClient> ICommonClientBuilder<BaiduSmartAppOpenApiClient>.UseInterceptor(HttpInterceptor interceptor)
        {
            return UseInterceptor(interceptor);
        }

        ICommonClientBuilder<BaiduSmartAppOpenApiClient> ICommonClientBuilder<BaiduSmartAppOpenApiClient>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            return UseHttpClient(httpClient, disposeClient);
        }

        public BaiduSmartAppOpenApiClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public BaiduSmartAppOpenApiClientBuilder UseInterceptor(HttpInterceptor interceptor)
        {
            if (interceptor is null) throw new ArgumentNullException(nameof(interceptor));

            _interceptors.Add(interceptor);
            return this;
        }

        public BaiduSmartAppOpenApiClientBuilder UseHttpClient(HttpClient httpClient, bool disposeClient = true)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _disposeClient = disposeClient;
            return this;
        }

        public BaiduSmartAppOpenApiClient Build()
        {
            BaiduSmartAppOpenApiClient client = _disposeClient.HasValue
                ? new BaiduSmartAppOpenApiClient(_options, _httpClient, _disposeClient.Value)
                : new BaiduSmartAppOpenApiClient(_options, _httpClient);

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

    partial class BaiduSmartAppOpenApiClientBuilder
    {
        public static BaiduSmartAppOpenApiClientBuilder Create(BaiduSmartAppOpenApiClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new BaiduSmartAppOpenApiClientBuilder(options);
        }
    }
}
