namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [POST] /app/del_tag 接口的请求。</para>
    /// </summary>
    public class AppDeleteTagRequest : BaiduPushRequest
    {
        /// <summary>
        /// 获取或设置标签名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag")]
        [System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string TagName { get; set; } = string.Empty;
    }
}
