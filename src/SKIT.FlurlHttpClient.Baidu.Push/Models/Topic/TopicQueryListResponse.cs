namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [GET] /topic/query_list 接口的响应。</para>
    /// </summary>
    public class TopicQueryListResponse : BaiduPushResponse<TopicQueryListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Topic
                    {
                        /// <summary>
                        /// 获取或设置分类主题 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("topic_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("topic_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string TopicId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置推送目标数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("push_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("push_cnt")]
                        public int PushCount { get; set; }

                        /// <summary>
                        /// 获取或设置消息到达数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ack_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("ack_cnt")]
                        public int AcknowledgeCount { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ctime")]
                        [System.Text.Json.Serialization.JsonPropertyName("ctime")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mtime")]
                        [System.Text.Json.Serialization.JsonPropertyName("mtime")]
                        public long UpdateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置分类主题列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("topics")]
                [System.Text.Json.Serialization.JsonPropertyName("topics")]
                public Types.Topic[] TopicList { get; set; } = default!;

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
