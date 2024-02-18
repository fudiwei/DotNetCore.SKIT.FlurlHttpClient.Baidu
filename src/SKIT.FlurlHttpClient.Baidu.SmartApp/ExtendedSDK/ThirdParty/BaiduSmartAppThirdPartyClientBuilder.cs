using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty
{
    /// <summary>
    /// 用于构造 <see cref="BaiduSmartAppThirdPartyClient"/> 实例的构造器。
    /// </summary>
    public partial class BaiduSmartAppThirdPartyClientBuilder : ICommonClientBuilder<BaiduSmartAppThirdPartyClient>
    {
        private readonly BaiduSmartAppThirdPartyClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;
        private HttpClient? _httpClient;
        private bool? _disposeClient;

        private BaiduSmartAppThirdPartyClientBuilder(BaiduSmartAppThirdPartyClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<BaiduSmartAppThirdPartyClient> ICommonClientBuilder<BaiduSmartAppThirdPartyClient>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<BaiduSmartAppThirdPartyClient> ICommonClientBuilder<BaiduSmartAppThirdPartyClient>.UseInterceptor(HttpInterceptor interceptor)
        {
            return UseInterceptor(interceptor);
        }

        ICommonClientBuilder<BaiduSmartAppThirdPartyClient> ICommonClientBuilder<BaiduSmartAppThirdPartyClient>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            return UseHttpClient(httpClient, disposeClient);
        }

        public BaiduSmartAppThirdPartyClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public BaiduSmartAppThirdPartyClientBuilder UseInterceptor(HttpInterceptor interceptor)
        {
            if (interceptor is null) throw new ArgumentNullException(nameof(interceptor));

            _interceptors.Add(interceptor);
            return this;
        }

        public BaiduSmartAppThirdPartyClientBuilder UseHttpClient(HttpClient httpClient, bool disposeClient = true)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _disposeClient = disposeClient;
            return this;
        }

        public BaiduSmartAppThirdPartyClient Build()
        {
            BaiduSmartAppThirdPartyClient client = _disposeClient.HasValue
                ? new BaiduSmartAppThirdPartyClient(_options, _httpClient, _disposeClient.Value)
                : new BaiduSmartAppThirdPartyClient(_options, _httpClient);

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

    partial class BaiduSmartAppThirdPartyClientBuilder
    {
        public static BaiduSmartAppThirdPartyClientBuilder Create(BaiduSmartAppThirdPartyClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new BaiduSmartAppThirdPartyClientBuilder(options);
        }
    }
}
