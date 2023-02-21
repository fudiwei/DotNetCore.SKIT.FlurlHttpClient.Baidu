namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/app/modifywebviewdomain 接口的响应。</para>
    /// </summary>
    public class RestAppModifyWebviewDomainResponse : BaiduSmartAppThirdPartyResponse
    {
        /// <summary>
        /// 获取或设置业务域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringArrayWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringArrayWithCommaSplitConverter))]
        public string[]? WebViewDomainList { get; set; }
    }
}
