namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/data/getanalysisactivityuser 接口的响应。</para>
    /// </summary>
    public class RestDataGetAnalysisActivityUserResponse : BaiduSmartAppThirdPartyResponse<RestDataGetAnalysisActivityUserResponse.Types.Data>
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
                        /// 获取或设置日活跃用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_count")]
                        public int DailyUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置日活跃度（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("daily_activity_degree")]
                        [System.Text.Json.Serialization.JsonPropertyName("daily_activity_degree")]
                        public decimal DailyActivityDegree { get; set; }

                        /// <summary>
                        /// 获取或设置日活月活比。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("day_month_activity_degree")]
                        [System.Text.Json.Serialization.JsonPropertyName("day_month_activity_degree")]
                        public decimal DayMonthActivityDegree { get; set; }

                        /// <summary>
                        /// 获取或设置周活跃用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("weekly_user_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("weekly_user_count")]
                        public int WeeklyUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置周活跃度（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("weekly_activity_degree")]
                        [System.Text.Json.Serialization.JsonPropertyName("weekly_activity_degree")]
                        public decimal WeeklyActivityDegree { get; set; }

                        /// <summary>
                        /// 获取或设置月活跃用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("monthly_user_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("monthly_user_count")]
                        public int MonthlyUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置月活跃度（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("monthly_activity_degree")]
                        [System.Text.Json.Serialization.JsonPropertyName("monthly_activity_degree")]
                        public decimal MonthlyActivityDegree { get; set; }

                        /// <summary>
                        /// 获取或设置流失用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("lost_user_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("lost_user_count")]
                        public int LostUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置流失率（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("lost_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("lost_ratio")]
                        public decimal LostRatio { get; set; }

                        /// <summary>
                        /// 获取或设置累计启动用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("accumulative_user_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("accumulative_user_count")]
                        public int AccumulativeUserCount { get; set; }
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
