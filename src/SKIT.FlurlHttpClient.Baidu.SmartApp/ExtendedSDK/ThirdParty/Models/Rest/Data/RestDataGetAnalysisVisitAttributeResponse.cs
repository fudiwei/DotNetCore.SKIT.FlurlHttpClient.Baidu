namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/data/getanalysisvisitattribute 接口的响应。</para>
    /// </summary>
    public class RestDataGetAnalysisVisitAttributeResponse : BaiduSmartAppThirdPartyResponse<RestDataGetAnalysisVisitAttributeResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Statistic
                    {
                        public static class Types
                        {
                            public class Attribute
                            {
                                /// <summary>
                                /// 获取或设置属性 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("attribute_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("attribute_id")]
                                public string AttributeId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置指标名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置数量比率（单位：百分数）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("count_ratio")]
                                [System.Text.Json.Serialization.JsonPropertyName("count_ratio")]
                                public decimal Ratio { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置年龄分布数据列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("age")]
                        [System.Text.Json.Serialization.JsonPropertyName("age")]
                        public Types.Attribute[] AgeAttributeList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置性别分布数据列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sex")]
                        [System.Text.Json.Serialization.JsonPropertyName("sex")]
                        public Types.Attribute[] SexAttributeList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置兴趣分布数据列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("interest")]
                        [System.Text.Json.Serialization.JsonPropertyName("interest")]
                        public Types.Attribute[] InterestAttributeList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置数据指标列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data_list")]
                [System.Text.Json.Serialization.JsonPropertyName("data_list")]
                public Types.Statistic[] StatisticList { get; set; } = default!;
            }
        }
    }
}
