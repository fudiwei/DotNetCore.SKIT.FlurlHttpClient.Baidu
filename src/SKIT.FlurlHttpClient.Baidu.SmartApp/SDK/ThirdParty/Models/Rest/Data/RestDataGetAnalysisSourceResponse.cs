namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/data/getanalysissource 接口的响应。</para>
    /// </summary>
    public class RestDataGetAnalysisSourceResponse : BaiduSmartAppThirdPartyResponse<RestDataGetAnalysisSourceResponse.Types.Data>
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
                        /// 获取或设置新用户数占比（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_user_scale")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_user_scale")]
                        public double NewUserRatio { get; set; }

                        /// <summary>
                        /// 获取或设置用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_count")]
                        public double UserCount { get; set; }

                        /// <summary>
                        /// 获取或设置用户数占比（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_scale")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_scale")]
                        public double UserRatio { get; set; }

                        /// <summary>
                        /// 获取或设置启动次数占比（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("session_scale")]
                        [System.Text.Json.Serialization.JsonPropertyName("session_scale")]
                        public double SessionRatio { get; set; }

                        /// <summary>
                        /// 获取或设置人均启动次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("session_count_per_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("session_count_per_user")]
                        public double AverageSessionCount { get; set; }

                        /// <summary>
                        /// 获取或设置次均使用时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("average_session_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("average_session_time")]
                        public double AverageSessionTime { get; set; }
                    }

                    public class Statistic : Summary
                    {
                        /// <summary>
                        /// 获取或设置指标名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置场景 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sceneId")]
                        [System.Text.Json.Serialization.JsonPropertyName("sceneId")]
                        public string SceneId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置来源。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("source")]
                        [System.Text.Json.Serialization.JsonPropertyName("source")]
                        public string Source { get; set; } = default!;
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
                public int Offset { get; set; }

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
