namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [GET] /report/query_msg_status 接口的响应。</para>
    /// </summary>
    public class ReportQueryMessageStatusResponse : BaiduPushResponse<ReportQueryMessageStatusResponse.Types.Data>
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
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
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

                        /// <summary>
                        /// 获取或设置成功到达数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("success")]
                        [System.Text.Json.Serialization.JsonPropertyName("success")]
                        public int SuccessCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置发送记录列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result")]
                [System.Text.Json.Serialization.JsonPropertyName("result")]
                public Types.Record[] RecordList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_num")]
                [System.Text.Json.Serialization.JsonPropertyName("total_num")]
                public int TotalCount { get; set; }
            }
        }
    }
}
