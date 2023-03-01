using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/flow/saveurlmapping 接口的请求。</para>
    /// </summary>
    public class RestFlowSaveUrlMappingRequest : BaiduSmartAppThirdPartyRequest
    {
        public static class Types
        {
            public class Rule
            {
                public static class Types
                {
                    public class UrlPair
                    {
                        /// <summary>
                        /// 获取或设置 H5 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("h5Url")]
                        [System.Text.Json.Serialization.JsonPropertyName("h5Url")]
                        public string? H5Url { get; set; }

                        /// <summary>
                        /// 获取或设置小程序 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appUrl")]
                        [System.Text.Json.Serialization.JsonPropertyName("appUrl")]
                        public string? SmartAppUrl { get; set; }
                    }
                }

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
                /// 获取或设置 URL 对列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("urlPairs")]
                [System.Text.Json.Serialization.JsonPropertyName("urlPairs")]
                public IList<Types.UrlPair>? UrlPairList { get; set; }
            }
        }

        internal static class Converters
        {
            internal class RequestPropertyRuleListNewtonsoftJsonConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<IList<Types.Rule>?>
            {
            }

            internal class RequestPropertyRuleListSystemTextJsonConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<IList<Types.Rule>?>
            {
            }
        }

        /// <summary>
        /// 获取或设置适配替换规则信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.RequestPropertyRuleListNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.RequestPropertyRuleListSystemTextJsonConverter))]

        public IList<Types.Rule> RuleList { get; set; } = new List<Types.Rule>();

        /// <summary>
        /// 获取或设置提交方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_method")]
        [System.Text.Json.Serialization.JsonPropertyName("create_method")]
        public int CreateMethod { get; set; }
    }
}
