namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/app/modifywebviewdomain 接口的请求。</para>
    /// </summary>
    public class RestAppModifyWebviewDomainRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置操作类型。
        /// <para>默认值："get"</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string? Action { get; set; } = "get";

        /// <summary>
        /// 获取或设置业务域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("web_view_domain")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedStringListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("web_view_domain")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedStringListWithCommaSplitConverter))]
        public List<string>? WebViewDomainList { get; set; }
    }
}
