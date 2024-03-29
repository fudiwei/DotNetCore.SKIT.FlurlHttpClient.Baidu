namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/ma/component/comment/tcount 接口的请求。</para>
    /// </summary>
    public class RestMAComponentCommentCountRequest : BaiduSmartAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置文章 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("snid")]
        [System.Text.Json.Serialization.JsonPropertyName("snid")]
        public string ContentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文章 ID 类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("snid_type")]
        [System.Text.Json.Serialization.JsonPropertyName("snid_type")]
        public string ContentIdType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置宿主标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? HostName { get; set; }
    }
}
