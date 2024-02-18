namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [GET] /report/query_topic_records 接口的响应。</para>
    /// </summary>
    public class ReportQueryTopicRecordsResponse : BaiduPushResponse<ReportQueryTopicRecordsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Record : ReportQueryTimerRecordsResponse.Types.Data.Types.Record
                    {
                    }
                }

                /// <summary>
                /// 获取或设置分类主题 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("topic_id")]
                [System.Text.Json.Serialization.JsonPropertyName("topic_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string TopicId { get; set; } = default!;

                /// <summary>
                /// 获取或设置发送记录列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result")]
                [System.Text.Json.Serialization.JsonPropertyName("result")]
                public Types.Record[] RecordList { get; set; } = default!;
            }
        }
    }
}
