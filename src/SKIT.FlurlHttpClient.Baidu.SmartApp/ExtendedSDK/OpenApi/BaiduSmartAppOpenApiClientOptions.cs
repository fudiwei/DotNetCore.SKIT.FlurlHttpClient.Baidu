namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi
{
    /// <summary>
    /// 一个用于构造 <see cref="BaiduSmartAppOpenApiClient"/> 时使用的配置项。
    /// </summary>
    public class BaiduSmartAppOpenApiClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置百度智能小程序 API 入口点。
        /// <para>默认值：<see cref="BaiduSmartAppOpenApiEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoint { get; set; } = BaiduSmartAppOpenApiEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置百度智能小程序 AppId。
        /// </summary>
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置百度智能小程序 AppKey。
        /// </summary>
        public string AppKey { get; set; } = default!;

        /// <summary>
        /// 获取或设置百度智能小程序 AppSecret。
        /// </summary>
        public string AppSecret { get; set; } = default!;

        /// <summary>
        /// 获取或设置百度智能小程序消息验证令牌。
        /// </summary>
        public string? PushToken { get; set; }

        /// <summary>
        /// 获取或设置百度智能小程序消息加解密密钥。
        /// </summary>
        public string? PushEncodingAESKey { get; set; }

        /// <summary>
        /// 获取或设置百度收银台支付服务的 AppKey。
        /// </summary>
        public string? PaymentServiceAppKey { get; set; }
    }
}
