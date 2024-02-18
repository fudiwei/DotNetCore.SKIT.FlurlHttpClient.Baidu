namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/data/getanalysisvisitpage 接口的响应。</para>
    /// </summary>
    public class RestDataGetAnalysisVisitPageResponse : BaiduSmartAppThirdPartyResponse<RestDataGetAnalysisVisitPageResponse.Types.Data>
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
                        /// 获取或设置页面访问次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pv_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("pv_count")]
                        public int PVCount { get; set; }

                        /// <summary>
                        /// 获取或设置访问次数占比（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pv_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("pv_ratio")]
                        public decimal PVRatio { get; set; }

                        /// <summary>
                        /// 获取或设置访问用户数（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pv_user_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("pv_user_count")]
                        public int PVUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置次均停留时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("average_stay_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("average_stay_time")]
                        public int AverageStayTime { get; set; }

                        /// <summary>
                        /// 获取或设置访问时长占比（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("stay_time_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("stay_time_ratio")]
                        public decimal StayTimeRatio { get; set; }

                        /// <summary>
                        /// 获取或设置退出率（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bounce_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("bounce_ratio")]
                        public decimal BounceRatio { get; set; }

                        /// <summary>
                        /// 获取或设置入口页次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("entry_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("entry_count")]
                        public int EntryCount { get; set; }

                        /// <summary>
                        /// 获取或设置退出页次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("exit_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("exit_count")]
                        public int ExitCount { get; set; }
                    }

                    public class Statistic : Summary
                    {
                        /// <summary>
                        /// 获取或设置页面 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pageId")]
                        [System.Text.Json.Serialization.JsonPropertyName("pageId")]
                        public string PageId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pageName")]
                        [System.Text.Json.Serialization.JsonPropertyName("pageName")]
                        public string PagePath { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置页面别名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pageAlias")]
                        [System.Text.Json.Serialization.JsonPropertyName("pageAlias")]
                        public string PageAlias { get; set; } = default!;
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
