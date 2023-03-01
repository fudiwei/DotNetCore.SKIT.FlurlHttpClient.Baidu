namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/promotion/topquery/keyword 接口的响应。</para>
    /// </summary>
    public class RestPromotionTopQueryKeywordResponse : BaiduSmartAppThirdPartyResponse<RestPromotionTopQueryKeywordResponse.Types.Data>
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
                        /// 获取或设置查询的关键词。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("query")]
                        [System.Text.Json.Serialization.JsonPropertyName("query")]
                        public string QueryKeyword { get; set; } = default!;

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
                        [Newtonsoft.Json.JsonProperty("rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("rate")]
                        public string CTRString { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置日期纬度的点击与展示列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail")]
                [System.Text.Json.Serialization.JsonPropertyName("detail")]
                public Types.Record[] RecordList { get; set; } = default!;

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
