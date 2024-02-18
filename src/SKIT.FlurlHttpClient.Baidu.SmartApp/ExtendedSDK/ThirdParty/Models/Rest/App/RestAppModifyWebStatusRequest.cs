namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/app/modifywebstatus 接口的请求。</para>
    /// </summary>
    public class RestAppModifyWebStatusRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置 Web 化开关状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("web_status")]
        [System.Text.Json.Serialization.JsonPropertyName("web_status")]
        public int WebStatus { get; set; }
    }
}
