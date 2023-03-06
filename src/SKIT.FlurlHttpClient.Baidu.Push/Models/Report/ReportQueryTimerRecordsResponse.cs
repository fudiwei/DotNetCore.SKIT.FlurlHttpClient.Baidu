namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [GET] /report/query_timer_records 接口的响应。</para>
    /// </summary>
    public class ReportQueryTimerRecordsResponse : BaiduPushResponse<ReportQueryTimerRecordsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Record
                    {
                        /// <summary>
                        /// 获取或设置消息 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("msg_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("msg_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string MessageId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置推送状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置推送时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("send_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("send_time")]
                        public long SendTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置定时任务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("timer_id")]
                [System.Text.Json.Serialization.JsonPropertyName("timer_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                public string TimerId { get; set; } = default!;

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
