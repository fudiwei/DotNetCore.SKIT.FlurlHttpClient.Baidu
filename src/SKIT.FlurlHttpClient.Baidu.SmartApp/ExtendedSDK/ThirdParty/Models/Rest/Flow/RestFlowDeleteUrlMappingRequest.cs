namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/flow/delurlmapping 接口的请求。</para>
    /// </summary>
    public class RestFlowDeleteUrlMappingRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置规则 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long RuleId { get; set; }
    }
}
