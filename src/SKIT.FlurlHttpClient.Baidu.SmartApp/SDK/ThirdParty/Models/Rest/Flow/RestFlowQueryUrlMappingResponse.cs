namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/flow/queryurlmapping 接口的响应。</para>
    /// </summary>
    public class RestFlowQueryUrlMappingResponse : BaiduSmartAppThirdPartyResponse<RestFlowQueryUrlMappingResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Rule
                    {
                        /// <summary>
                        /// 获取或设置规则 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ruleId")]
                        [System.Text.Json.Serialization.JsonPropertyName("ruleId")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long RuleId { get; set; }

                        /// <summary>
                        /// 获取或设置 H5 规则。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("h5Rule")]
                        [System.Text.Json.Serialization.JsonPropertyName("h5Rule")]
                        public string? H5Pattern { get; set; }

                        /// <summary>
                        /// 获取或设置小程序规则。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appRule")]
                        [System.Text.Json.Serialization.JsonPropertyName("appRule")]
                        public string? SmartAppPattern { get; set; }

                        /// <summary>
                        /// 获取或设置提交方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("createMethod")]
                        [System.Text.Json.Serialization.JsonPropertyName("createMethod")]
                        public int CreateMethod { get; set; }

                        /// <summary>
                        /// 获取或设置状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置状态说明。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("msg")]
                        [System.Text.Json.Serialization.JsonPropertyName("msg")]
                        public string StatusMessage { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置提交时间字符串（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("submitTime")]
                        [System.Text.Json.Serialization.JsonPropertyName("submitTime")]
                        public string SubmitTimeString { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置适配替换规则信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ruleDetailList")]
                [System.Text.Json.Serialization.JsonPropertyName("ruleDetailList")]

                public Types.Rule[] RuleList { get; set; } = default!;

                /// <summary>
                /// 获取或设置适配规则总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ruleTotalNum")]
                [System.Text.Json.Serialization.JsonPropertyName("ruleTotalNum")]
                public int TotalRuleCount { get; set; }

                /// <summary>
                /// 获取或设置适配资源生效数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("totalAdapterNum")]
                [System.Text.Json.Serialization.JsonPropertyName("totalAdapterNum")]
                public int TotalAdapterCount { get; set; }

                /// <summary>
                /// 获取或设置规则剩余可用数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ruleRemainingNum")]
                [System.Text.Json.Serialization.JsonPropertyName("ruleRemainingNum")]
                public int RemainingRuleCount { get; set; }
            }
        }
    }
}
