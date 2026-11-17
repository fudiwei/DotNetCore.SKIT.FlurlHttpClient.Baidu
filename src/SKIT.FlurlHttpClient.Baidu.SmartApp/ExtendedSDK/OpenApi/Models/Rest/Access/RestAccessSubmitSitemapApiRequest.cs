namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/access/submitsitemap/api 接口的请求。</para>
    /// </summary>
    public class RestAccessSubmitSitemapApiRequest : BaiduSmartAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置上传级别。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int UploadType { get; set; }

        /// <summary>
        /// 获取或设置 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url_list")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedStringListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("url_list")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedStringListWithCommaSplitConverter))]
        public List<string>? UrlList { get; set; }
    }
}
