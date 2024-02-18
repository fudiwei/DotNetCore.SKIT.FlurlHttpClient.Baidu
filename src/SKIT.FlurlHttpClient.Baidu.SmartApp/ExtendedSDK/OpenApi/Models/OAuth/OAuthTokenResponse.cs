namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /oauth/2.0/token 接口的响应。</para>
    /// </summary>
    public class OAuthTokenResponse : BaiduSmartAppOpenApiResponse
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
        /// 获取或设置接口调用凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public string AccessToken { get; set; } = default!;

        /// <summary>
        /// 获取或设置接口调用凭证有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires_in")]
        [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && (string.IsNullOrEmpty(Error) || "success".Equals(Error) || "ok".Equals(Error));
        }
    }
}
