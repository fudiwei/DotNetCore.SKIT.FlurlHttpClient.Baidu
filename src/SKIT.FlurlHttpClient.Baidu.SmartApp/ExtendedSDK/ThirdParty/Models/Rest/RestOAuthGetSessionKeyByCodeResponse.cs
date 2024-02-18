namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/oauth/getsessionkeybycode 接口的响应。</para>
    /// </summary>
    public class RestOAuthGetSessionKeyByCodeResponse : BaiduSmartAppThirdPartyResponse
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? ErrorMessage
        {
            get { return ErrorDescription; }
            set { ErrorDescription = value; }
        }

        /// <summary>
        /// 获取或设置异常情况。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error")]
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 获取或设置异常提示信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_description")]
        [System.Text.Json.Serialization.JsonPropertyName("error_description")]
        public string? ErrorDescription { get; set; }

        /// <summary>
        /// 获取或设置用户身份标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户登录态密钥。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("session_key")]
        [System.Text.Json.Serialization.JsonPropertyName("session_key")]
        public string SessionKey { get; set; } = default!;
    }
}
