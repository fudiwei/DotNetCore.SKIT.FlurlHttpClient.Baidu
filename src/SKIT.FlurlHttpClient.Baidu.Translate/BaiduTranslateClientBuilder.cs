using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.Baidu.Translate
{
    /// <summary>
    /// 用于构造 <see cref="BaiduTranslateClient"/> 实例的构造器。
    /// </summary>
    public partial class BaiduTranslateClientBuilder : ICommonClientBuilder<BaiduTranslateClient>
    {
        private readonly BaiduTranslateClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;
        private HttpClient? _httpClient;
        private bool? _disposeClient;

        private BaiduTranslateClientBuilder(BaiduTranslateClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<BaiduTranslateClient> ICommonClientBuilder<BaiduTranslateClient>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<BaiduTranslateClient> ICommonClientBuilder<BaiduTranslateClient>.UseInterceptor(HttpInterceptor interceptor)
        {
            return UseInterceptor(interceptor);
        }

        ICommonClientBuilder<BaiduTranslateClient> ICommonClientBuilder<BaiduTranslateClient>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            return UseHttpClient(httpClient, disposeClient);
        }

        public BaiduTranslateClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public BaiduTranslateClientBuilder UseInterceptor(HttpInterceptor interceptor)
        {
            if (interceptor is null) throw new ArgumentNullException(nameof(interceptor));

            _interceptors.Add(interceptor);
            return this;
        }

        public BaiduTranslateClientBuilder UseHttpClient(HttpClient httpClient, bool disposeClient = true)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _disposeClient = disposeClient;
            return this;
        }

        public BaiduTranslateClient Build()
        {
            BaiduTranslateClient client = _disposeClient.HasValue
                ? new BaiduTranslateClient(_options, _httpClient, _disposeClient.Value)
                : new BaiduTranslateClient(_options, _httpClient);

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

    partial class BaiduTranslateClientBuilder
    {
        public static BaiduTranslateClientBuilder Create(BaiduTranslateClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new BaiduTranslateClientBuilder(options);
        }
    }
}
