namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [POST] /tag/device_num 接口的请求。</para>
    /// </summary>
    public class TagDeviceNumberRequest : BaiduPushRequest
    {
        /// <summary>
        /// 获取或设置标签名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag")]
        [System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string TagName { get; set; } = string.Empty;
    }
}
