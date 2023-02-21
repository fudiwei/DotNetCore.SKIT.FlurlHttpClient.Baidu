namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi
{
    /// <summary>
    /// 表示百度智能小程序 API 请求的基类。
    /// </summary>
    public abstract class BaiduSmartAppOpenApiRequest : ICommonRequest
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。如果不指定将使用构造 <see cref="BaiduSmartAppOpenApiClient"/> 时的 <see cref="BaiduSmartAppOpenApiClientOptions.Timeout"/> 参数，这在需要指定特定耗时请求（比如上传或下载文件）的超时时间时很有用。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual int? Timeout { get; set; }

        /// <summary>
        /// 获取或设置百度智能小程序 AccessToken。
        /// <para>注意：部分第三方平台的接口中该字段表示授权方的 AuthorizerAccessToken。</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? AccessToken { get; set; }
    }
}
