namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/prelink/set 接口的请求。</para>
    /// </summary>
    public class RestPrelinkSetRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置 Prelink 链接列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prelink_url")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedStringListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("prelink_url")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedStringListWithCommaSplitConverter))]
        public List<string>? PrelinkUrlList { get; set; }
    }
}
