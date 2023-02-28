using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/template/add 接口的请求。</para>
    /// </summary>
    public class RestTemplateAddRequest : BaiduSmartAppThirdPartyRequest
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
        [System.Text.Json.Serialization.JsonPropertyName("keyword_id_list")]
        public IList<int> KeywordIdList { get; set; } = new List<int>();
    }
}
