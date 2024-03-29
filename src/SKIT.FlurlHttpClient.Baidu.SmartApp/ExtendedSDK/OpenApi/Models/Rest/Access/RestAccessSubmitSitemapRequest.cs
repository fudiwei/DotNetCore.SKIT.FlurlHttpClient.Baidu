namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/access/submitsitemap 接口的请求。</para>
    /// </summary>
    public class RestAccessSubmitSitemapRequest : BaiduSmartAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="BaiduSmartAppOpenApiClient"/> 时的 <see cref="BaiduSmartAppOpenApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int ActionType { get; set; }

        /// <summary>
        /// 获取或设置更新频率类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("frequency")]
        [System.Text.Json.Serialization.JsonPropertyName("frequency")]
        public int FrequencyType { get; set; }

        /// <summary>
        /// 获取或设置描述信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc")]
        [System.Text.Json.Serialization.JsonPropertyName("desc")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置 sitemap URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string SitemapUrl { get; set; } = string.Empty;
    }
}
