using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/template/templateadd 接口的请求。</para>
    /// </summary>
    public class RestTemplateAddRequest : BaiduSmartAppOpenApiRequest
    {
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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("keyword_id_list")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedObjectInJsonFormatConverter))]
        public IList<int> KeywordIdList { get; set; } = new List<int>();
    }
}
