namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/pay/tp/getTradeIndustryList 接口的响应。</para>
    /// </summary>
    public class RestPayThirdPartyGetTradeIndustryListResponse : BaiduSmartAppThirdPartyResponse<RestPayThirdPartyGetTradeIndustryListResponse.Types.Industry[]>
    {
        public static class Types
        {
            public class Industry
            {
                /// <summary>
                /// 获取或设置行业 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("industryId")]
                [System.Text.Json.Serialization.JsonPropertyName("industryId")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int IndustryId { get; set; }

                /// <summary>
                /// 获取或设置行业名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("industryName")]
                [System.Text.Json.Serialization.JsonPropertyName("industryName")]
                public string IndustryName { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否需要资质。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("needPermit")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("needPermit")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                public bool RequirePermit { get; set; }

                /// <summary>
                /// 获取或设置资质描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("permitDesc")]
                [System.Text.Json.Serialization.JsonPropertyName("permitDesc")]
                public string? PermitDescription { get; set; }

                /// <summary>
                /// 获取或设置父级行业 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parentIndustryId")]
                [System.Text.Json.Serialization.JsonPropertyName("parentIndustryId")]
                public int ParentIndustryId { get; set; }

                /// <summary>
                /// 获取或设置子级行业列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("industryList")]
                [System.Text.Json.Serialization.JsonPropertyName("industryList")]
                public Types.Industry[]? SubIndustryList { get; set; }
            }
        }
    }
}
