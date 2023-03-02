using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/template/templateadd 接口的请求。</para>
    /// </summary>
    public class RestTemplateAddRequest : BaiduSmartAppOpenApiRequest
    {
        internal static class Converters
        {
            internal class RequestPropertyKeywordIdListNewtonsoftJsonConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<IList<int>?>
            {
            }

            internal class RequestPropertKeywordIdListSystemTextJsonConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<IList<int>?>
            {
            }
        }

        /// <summary>
        /// 获取或设置模板标题 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置模板关键词 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword_id_list")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.RequestPropertyKeywordIdListNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("keyword_id_list")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.RequestPropertKeywordIdListSystemTextJsonConverter))]
        public IList<int> KeywordIdList { get; set; } = new List<int>();
    }
}
