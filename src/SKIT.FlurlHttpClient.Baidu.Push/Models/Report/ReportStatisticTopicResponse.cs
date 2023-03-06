using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [GET] /report/statistic_topic 接口的响应。</para>
    /// </summary>
    public class ReportStatisticTopicResponse : BaiduPushResponse<ReportStatisticTopicResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Statistic
                    {
                        /// <summary>
                        /// 获取或设置消息到达数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ack")]
                        [System.Text.Json.Serialization.JsonPropertyName("ack")]
                        public int AcknowledgeCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置统计信息字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result")]
                [System.Text.Json.Serialization.JsonPropertyName("result")]
                public IDictionary<long, Types.Statistic> StatisticMap { get; set; } = default!;

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
