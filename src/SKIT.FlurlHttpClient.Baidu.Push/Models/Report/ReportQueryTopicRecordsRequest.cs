namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [GET] /report/query_topic_records 接口的请求。</para>
    /// </summary>
    public class ReportQueryTopicRecordsRequest : BaiduPushRequest
    {
        /// <summary>
        /// 获取或设置分类主题 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string TopicId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置返回记录的起始索引位置。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Start { get; set; }

        /// <summary>
        /// 获取或设置返回记录的条数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Limit { get; set; }

        /// <summary>
        /// 获取或设置查询起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置查询截止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? EndTimestamp { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override int? DeviceType { get; set; }
    }
}
