namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/app/modifywebviewdomain 接口的响应。</para>
    /// </summary>
    public class RestAppModifyWebviewDomainResponse : BaiduSmartAppThirdPartyResponse<List<string>?>
    {
        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("data")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedStringListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedStringListWithCommaSplitConverter))]
        public override List<string>? Data { get; set; }
    }
}
