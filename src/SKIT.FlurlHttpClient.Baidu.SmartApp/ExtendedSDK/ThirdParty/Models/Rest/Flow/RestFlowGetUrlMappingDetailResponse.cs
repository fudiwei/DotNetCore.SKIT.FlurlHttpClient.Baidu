namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/flow/geturlmappingdetail 接口的响应。</para>
    /// </summary>
    public class RestFlowGetUrlMappingDetailResponse : BaiduSmartAppThirdPartyResponse<RestFlowGetUrlMappingDetailResponse.Types.Rule[]>
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
                [Newtonsoft.Json.JsonProperty("h5Pattern")]
                [System.Text.Json.Serialization.JsonPropertyName("h5Pattern")]
                public string? H5Pattern { get; set; }

                /// <summary>
                /// 获取或设置小程序规则。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appPattern")]
                [System.Text.Json.Serialization.JsonPropertyName("appPattern")]
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

                /// <summary>
                /// 获取或设置是否匹配。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("isFetch")]
                [System.Text.Json.Serialization.JsonPropertyName("isFetch")]
                public bool IsFetch { get; set; }

                /// <summary>
                /// 获取或设置匹配数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("matchNum")]
                [System.Text.Json.Serialization.JsonPropertyName("matchNum")]
                public int MatchCount { get; set; }

                /// <summary>
                /// 获取或设置适配数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("adapterNum")]
                [System.Text.Json.Serialization.JsonPropertyName("adapterNum")]
                public int AdapterCount { get; set; }

                /// <summary>
                /// 获取或设置累计替换数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coverNum")]
                [System.Text.Json.Serialization.JsonPropertyName("coverNum")]
                public int CoverCount { get; set; }

                /// <summary>
                /// 获取或设置适配状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("adapterStatus")]
                [System.Text.Json.Serialization.JsonPropertyName("adapterStatus")]
                public int AdapterStatus { get; set; }

                /// <summary>
                /// 获取或设置流量替换占比（单位：百分数）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("urlRate")]
                [System.Text.Json.Serialization.JsonPropertyName("urlRate")]
                public decimal UrlRate { get; set; }
            }
        }
    }
}
