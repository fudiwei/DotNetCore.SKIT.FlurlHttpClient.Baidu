namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/app/modifysignature 接口的请求。</para>
    /// </summary>
    public class RestAppModifySignatureRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置小程序介绍。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("signature")]
        [System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string AppDescription { get; set; } = string.Empty;
    }
}
