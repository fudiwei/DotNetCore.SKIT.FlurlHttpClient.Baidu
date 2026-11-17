namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/access/submitsitemap/api 接口的响应。</para>
    /// </summary>
    public class RestAccessSubmitSitemapApiResponse : BaiduSmartAppOpenApiResponse
    {
        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public override string? ErrorMessage { get; set; }
    }
}
