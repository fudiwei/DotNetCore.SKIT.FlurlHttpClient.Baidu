using System;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="BaiduSmartAppOpenApiClientOptions.AppId"/> 的副本。
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 初始化客户端时 <see cref="BaiduSmartAppOpenApiClientOptions.AppKey"/> 的副本。
        /// </summary>
        public string AppKey { get; set; }

        /// <summary>
        /// 初始化客户端时 <see cref="BaiduSmartAppOpenApiClientOptions.AppSecret"/> 的副本。
        /// </summary>
        public string AppSecret { get; set; }

        /// <summary>
        /// 初始化客户端时 <see cref="BaiduSmartAppOpenApiClientOptions.PushToken"/> 的副本。
        /// </summary>
        public string? PushToken { get; set; }

        /// <summary>
        /// 初始化客户端时 <see cref="BaiduSmartAppOpenApiClientOptions.PushEncodingAESKey"/> 的副本。
        /// </summary>
        public string? PushEncodingAESKey { get; set; }

        /// <summary>
        /// 初始化客户端时 <see cref="BaiduSmartAppOpenApiClientOptions.PaymentServiceAppKey"/> 的副本。
        /// </summary>
        public string? PaymentServiceAppKey { get; set; }

        internal Credentials(BaiduSmartAppOpenApiClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            AppId = options.AppId;
            AppKey = options.AppKey;
            AppSecret = options.AppSecret;
            PushToken = options.PushToken;
            PushEncodingAESKey = options.PushEncodingAESKey;
            PaymentServiceAppKey = options.PaymentServiceAppKey;
        }
    }
}
