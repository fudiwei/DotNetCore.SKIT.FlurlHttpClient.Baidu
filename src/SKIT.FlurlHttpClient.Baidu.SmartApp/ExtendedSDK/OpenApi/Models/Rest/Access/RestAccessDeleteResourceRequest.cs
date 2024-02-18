namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/access/deleteresource 接口的请求。</para>
    /// </summary>
    public class RestAccessDeleteResourceRequest : BaiduSmartAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="BaiduSmartAppOpenApiClient"/> 时的 <see cref="BaiduSmartAppOpenApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置落地页页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path")]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public string PagePath { get; set; } = string.Empty;
    }
}
