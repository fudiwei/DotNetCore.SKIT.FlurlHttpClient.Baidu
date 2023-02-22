namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/appflow/control 接口的请求。</para>
    /// </summary>
    public class RestAppFlowControlRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置流量下线开关状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }
    }
}
