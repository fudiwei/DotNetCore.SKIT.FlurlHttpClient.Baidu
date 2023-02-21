namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/template/addtotemplate 接口的请求。</para>
    /// </summary>
    public class RestTemplateAddToTemplateRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置草稿 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("draft_id")]
        [System.Text.Json.Serialization.JsonPropertyName("draft_id")]
        public long DraftId { get; set; }

        /// <summary>
        /// 获取或设置自定义描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("user_desc")]
        public string UserDescription { get; set; } = string.Empty;
    }
}
