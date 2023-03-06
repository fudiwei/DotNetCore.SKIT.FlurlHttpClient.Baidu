namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [GET] /report/statistic_topic 接口的请求。</para>
    /// </summary>
    public class ReportStatisticTopicRequest : BaiduPushRequest
    {
        /// <summary>
        /// 获取或设置分类主题 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string TopicId { get; set; } = string.Empty;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override int? DeviceType { get; set; }
    }
}
