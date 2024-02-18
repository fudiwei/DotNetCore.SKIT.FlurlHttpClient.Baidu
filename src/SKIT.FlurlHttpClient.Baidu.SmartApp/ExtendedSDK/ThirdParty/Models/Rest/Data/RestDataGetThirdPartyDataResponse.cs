namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/data/gettpdata 接口的响应。</para>
    /// </summary>
    public class RestDataGetThirdPartyDataResponse : BaiduSmartAppThirdPartyResponse<RestDataGetThirdPartyDataResponse.Types.Data>
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
                        /// 获取或设置日期字符串（格式：yyyyMMdd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("data")]
                        [System.Text.Json.Serialization.JsonPropertyName("data")]
                        public string DateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置当日小程序数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tp_day_app_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("tp_day_app_count")]
                        public int DailyAppCount { get; set; }

                        /// <summary>
                        /// 获取或设置近 7 日小程序数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tp_week_app_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("tp_week_app_count")]
                        public int WeeklyAppCount { get; set; }

                        /// <summary>
                        /// 获取或设置近 30 日小程序数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tp_month_app_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("tp_month_app_count")]
                        public int MonthlyAppCount { get; set; }

                        /// <summary>
                        /// 获取或设置当日启动用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tp_day_user_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("tp_day_user_count")]
                        public int DailyUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置近 7 日启动用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tp_week_user_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("tp_week_user_count")]
                        public int WeeklyUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置近 30 日启动用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tp_month_user_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("tp_month_user_count")]
                        public int MonthlyUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置当日新用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tp_day_new_user_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("tp_day_new_user_count")]
                        public int DailyNewUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置近 7 日新用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tp_week_new_user_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("tp_week_new_user_count")]
                        public int WeeklyNewUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置近 30 日新用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tp_month_new_user_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("tp_month_new_user_count")]
                        public int MonthlyNewUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置当日启动次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tp_day_session_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("tp_day_session_count")]
                        public int DailySessionCount { get; set; }

                        /// <summary>
                        /// 获取或设置近 7 日启动次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tp_week_session_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("tp_week_session_count")]
                        public int WeeklySessionCount { get; set; }

                        /// <summary>
                        /// 获取或设置近 30 日启动次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tp_month_session_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("tp_month_session_count")]
                        public int MonthlySessionCount { get; set; }

                        /// <summary>
                        /// 获取或设置当日页面访问次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tp_day_page_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("tp_day_page_count")]
                        public int DailyPVCount { get; set; }

                        /// <summary>
                        /// 获取或设置当日小程序活跃度（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tp_activity_degree")]
                        [System.Text.Json.Serialization.JsonPropertyName("tp_activity_degree")]
                        public decimal DailyActivityDegree { get; set; }

                        /// <summary>
                        /// 获取或设置当日人均使用时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tp_session_time_per_person")]
                        [System.Text.Json.Serialization.JsonPropertyName("tp_session_time_per_person")]
                        public int DailyAverageSessionTimePerUser { get; set; }

                        /// <summary>
                        /// 获取或设置当日次均使用时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tp_session_time_per_day")]
                        [System.Text.Json.Serialization.JsonPropertyName("tp_session_time_per_day")]
                        public int DailyAverageSessionTimePerDay { get; set; }

                        /// <summary>
                        /// 获取或设置当日分享次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tp_day_share_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("tp_day_share_count")]
                        public int DailyShareCount { get; set; }

                        /// <summary>
                        /// 获取或设置当日回流次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tp_day_back_flow_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("tp_day_back_flow_count")]
                        public int DailyBackflowCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置数据指标列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result")]
                [System.Text.Json.Serialization.JsonPropertyName("result")]
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
