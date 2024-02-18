namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/data/getanalysisusertrend 接口的响应。</para>
    /// </summary>
    public class RestDataGetAnalysisUserTrendResponse : BaiduSmartAppThirdPartyResponse<RestDataGetAnalysisUserTrendResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Summary
                    {
                        /// <summary>
                        /// 获取或设置新用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_user_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_user_count")]
                        public int NewUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置新用户占比（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_user_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_user_ratio")]
                        public decimal NewUserRatio { get; set; }

                        /// <summary>
                        /// 获取或设置老用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("old_user_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("old_user_count")]
                        public int OldUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置老用户占比（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("old_user_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("old_user_ratio")]
                        public decimal OldUserRatio { get; set; }

                        /// <summary>
                        /// 获取或设置启动人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_count")]
                        public int UserCount { get; set; }

                        /// <summary>
                        /// 获取或设置启动次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("session_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("session_count")]
                        public int SessionCount { get; set; }

                        /// <summary>
                        /// 获取或设置次均使用时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("average_session_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("average_session_time")]
                        public int AverageSessionTime { get; set; }

                        /// <summary>
                        /// 获取或设置人均使用时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("session_time_per_person")]
                        [System.Text.Json.Serialization.JsonPropertyName("session_time_per_person")]
                        public int AverageSessionTimePerUser { get; set; }
                    }

                    public class Statistic : Summary
                    {
                        /// <summary>
                        /// 获取或设置指标名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置时间范围。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("time_span")]
                [System.Text.Json.Serialization.JsonPropertyName("time_span")]
                public string TimeRange { get; set; } = default!;

                /// <summary>
                /// 获取或设置数据综合指标信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sum")]
                [System.Text.Json.Serialization.JsonPropertyName("sum")]
                public Types.Summary Summary { get; set; } = default!;

                /// <summary>
                /// 获取或设置数据指标列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data_list")]
                [System.Text.Json.Serialization.JsonPropertyName("data_list")]
                public Types.Statistic[] StatisticList { get; set; } = default!;

                /// <summary>
                /// 获取或设置当前偏移位置。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("offset")]
                [System.Text.Json.Serialization.JsonPropertyName("offset")]
                public int PageOffset { get; set; }

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
            }
        }
    }
}
