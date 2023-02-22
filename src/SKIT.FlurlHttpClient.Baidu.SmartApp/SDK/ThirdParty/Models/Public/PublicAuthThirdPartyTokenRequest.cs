namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /public/2.0/smartapp/auth/tp/token 接口的请求。</para>
    /// </summary>
    public class PublicAuthThirdPartyTokenRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置第三方平台服务器推送的 Ticket。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Ticket { get; set; } = string.Empty;
    }
}
