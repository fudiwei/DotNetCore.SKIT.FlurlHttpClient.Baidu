namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/access/deletesitemap 接口的请求。</para>
    /// </summary>
    public class RestAccessDeleteSitemapRequest : BaiduSmartAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="BaiduSmartAppOpenApiClient"/> 时的 <see cref="BaiduSmartAppOpenApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置 sitemap URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string SitemapUrl { get; set; } = string.Empty;
    }
}
