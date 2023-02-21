namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/auth/retrieve/authorizationcode 接口的请求。</para>
    /// </summary>
    public class RestAuthRetrieveAuthorizationCodeRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置授权小程序的 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string AuthorizerAppId { get; set; } = string.Empty;
    }
}
