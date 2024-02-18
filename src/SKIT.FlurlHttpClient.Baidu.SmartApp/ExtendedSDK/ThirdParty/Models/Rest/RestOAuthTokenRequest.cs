namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/oauth/token 接口的请求。</para>
    /// </summary>
    public class RestOAuthTokenRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置授权码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Code { get; set; }

        /// <summary>
        /// 获取或设置接口调用凭证刷新令牌。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? RefreshToken { get; set; }

        /// <summary>
        /// 获取或设置授权方式。
        /// <para>默认值：app_to_tp_authorization_code</para>
        /// </summary>
        public string GrantType { get; set; } = "app_to_tp_authorization_code";
    }
}
