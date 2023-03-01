namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/promotion/sitemap/getanalysisctr 接口的响应。</para>
    /// </summary>
    public class RestPromotionSitemapGetAnalysisCTRResponse : BaiduSmartAppThirdPartyResponse<RestPromotionSitemapGetAnalysisCTRResponse.Types.Data>
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
                        /// 获取或设置日期字符串（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date")]
                        [System.Text.Json.Serialization.JsonPropertyName("date")]
                        public string DateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置点击量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("click_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("click_count")]
                        public int ClickCount { get; set; }

                        /// <summary>
                        /// 获取或设置展现量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("display_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("display_count")]
                        public int DisplayCount { get; set; }

                        /// <summary>
                        /// 获取或设置点展比字符串（格式：0.00%）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("click_view_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("click_view_ratio")]
                        public string CTRString { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置累计点击量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_click_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_click_count")]
                public int TotalClickCount { get; set; }

                /// <summary>
                /// 获取或设置累计展现量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_display_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_display_count")]
                public int TotalDisplayCount { get; set; }

                /// <summary>
                /// 获取或设置点展比字符串（格式：0.00%）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("click_display_ratio")]
                [System.Text.Json.Serialization.JsonPropertyName("click_display_ratio")]
                public string CTRString { get; set; } = default!;

                /// <summary>
                /// 获取或设置日期纬度的点击与展示列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("traffic_data")]
                [System.Text.Json.Serialization.JsonPropertyName("traffic_data")]
                public Types.Record[] RecordList { get; set; } = default!;
            }
        }
    }
}
