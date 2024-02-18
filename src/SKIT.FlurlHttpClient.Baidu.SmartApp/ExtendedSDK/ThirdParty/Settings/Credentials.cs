using System;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时  <see cref="BaiduSmartAppThirdPartyClientOptions.AppId"/> 的副本。
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 初始化客户端时  <see cref="BaiduSmartAppThirdPartyClientOptions.AppKey"/> 的副本。
        /// </summary>
        public string AppKey { get; set; }

        /// <summary>
        /// 初始化客户端时 或 <see cref="BaiduSmartAppThirdPartyClientOptions.AppSecret"/> 的副本。
        /// </summary>
        public string AppSecret { get; set; }

        /// <summary>
        /// 初始化客户端时 或 <see cref="BaiduSmartAppThirdPartyClientOptions.PushToken"/> 的副本。
        /// </summary>
        public string? PushToken { get; set; }

        /// <summary>
        /// 初始化客户端时 <see cref="BaiduSmartAppThirdPartyClientOptions.PushEncodingAESKey"/> 的副本。
        /// </summary>
        public string? PushEncodingAESKey { get; set; }

        /// <summary>
        /// 初始化客户端时 <see cref="BaiduSmartAppThirdPartyClientOptions.PaymentServiceAppKey"/> 的副本。
        /// </summary>
        public string? PaymentServiceAppKey { get; set; }

        internal Credentials(BaiduSmartAppThirdPartyClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            AppId = options.AppId;
            AppKey = options.AppKey;
            AppSecret = options.AppSecret;
            PushToken = options.PushToken;
            PushEncodingAESKey = options.PushEncodingAESKey;
            PaymentServiceAppKey = options.PaymentServiceAppKey;
        }
    }
}
