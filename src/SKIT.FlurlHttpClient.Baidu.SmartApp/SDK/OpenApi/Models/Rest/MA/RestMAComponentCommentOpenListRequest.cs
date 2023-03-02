namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/ma/component/comment/open_list 接口的请求。</para>
    /// </summary>
    public class RestMAComponentCommentOpenListRequest : BaiduSmartAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start")]
        [System.Text.Json.Serialization.JsonPropertyName("start")]
        public int PageOffset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：20</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("num")]
        [System.Text.Json.Serialization.JsonPropertyName("num")]
        public int PageSize { get; set; } = 20;

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
