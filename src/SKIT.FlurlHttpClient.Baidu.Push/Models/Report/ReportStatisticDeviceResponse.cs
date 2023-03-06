using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [GET] /report/statistic_device 接口的响应。</para>
    /// </summary>
    public class ReportStatisticDeviceResponse : BaiduPushResponse<ReportStatisticDeviceResponse.Types.Data>
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
                        /// 获取或设置新增用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_term")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_term")]
                        public int NewTermCount { get; set; }

                        /// <summary>
                        /// 获取或设置解绑用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("del_term")]
                        [System.Text.Json.Serialization.JsonPropertyName("del_term")]
                        public int DeletedTermCount { get; set; }

                        /// <summary>
                        /// 获取或设置在线用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("online_term")]
                        [System.Text.Json.Serialization.JsonPropertyName("online_term")]
                        public int OnlineTermCount { get; set; }

                        /// <summary>
                        /// 获取或设置累计终端数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("addup_term")]
                        [System.Text.Json.Serialization.JsonPropertyName("addup_term")]
                        public int AddupTermCount { get; set; }

                        /// <summary>
                        /// 获取或设置有效终端总数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_term")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_term")]
                        public int TotalTermCount { get; set; }
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
