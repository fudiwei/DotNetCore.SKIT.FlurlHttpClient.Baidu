namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty
{
    using SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi;

    /// <summary>
    /// 表示百度智能小程序第三方平台 API 响应的基类。
    /// </summary>
    public abstract class BaiduSmartAppThirdPartyResponse : BaiduSmartAppOpenApiResponse
    {
    }

    /// <summary>
    /// 表示百度智能小程序第三方平台 API 响应的基类。
    /// </summary>
    public abstract class BaiduSmartAppThirdPartyResponse<T> : BaiduSmartAppThirdPartyResponse
    {
        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public virtual T Data { get; set; } = default!;
    }
}
