namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/flow/bindsite 接口的请求。</para>
    /// </summary>
    public class RestFlowBindSiteRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置站点列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sites")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedStringListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("sites")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedStringListWithCommaSplitConverter))]
        public List<string>? SiteList { get; set; }
    }
}
