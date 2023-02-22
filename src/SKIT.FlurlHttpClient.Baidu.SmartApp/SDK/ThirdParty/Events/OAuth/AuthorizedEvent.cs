namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Events
{
    /// <summary>
    /// <para>表示 AUTHORIZED 事件的数据。</para>
    /// <para>REF: https://smartprogram.baidu.com/docs/third/auth/auth_push/ </para>
    /// </summary>
    public class AuthorizedEvent : BaiduSmartAppThirdPartyEvent
    {
        /// <summary>
        /// 授权码可以授权码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorizationCode")]
        [System.Text.Json.Serialization.JsonPropertyName("authorizationCode")]
        public string AuthorizationCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权码有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorizationCodeExpiresIn")]
        [System.Text.Json.Serialization.JsonPropertyName("authorizationCodeExpiresIn")]
        public int AuthorizationCodeExpiresIn { get; set; }
    }
}
