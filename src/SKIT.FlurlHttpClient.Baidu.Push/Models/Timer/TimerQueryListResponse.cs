namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [GET] /timer/query_list 接口的响应。</para>
    /// </summary>
    public class TimerQueryListResponse : BaiduPushResponse<TimerQueryListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Timer
                    {
                        /// <summary>
                        /// 获取或设置定时任务 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("timer_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("timer_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string TimerId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置消息内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("msg")]
                        [System.Text.Json.Serialization.JsonPropertyName("msg")]
                        public string Message { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置消息类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("msg_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("msg_type")]
                        public int MessageType { get; set; }

                        /// <summary>
                        /// 获取或设置消息发送范围。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("range_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("range_type")]
                        public int RangeType { get; set; }

                        /// <summary>
                        /// 获取或设置推送时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("send_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("send_time")]
                        public long SendTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置定时任务列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result")]
                [System.Text.Json.Serialization.JsonPropertyName("result")]
                public Types.Timer[] TimerList { get; set; } = default!;

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
