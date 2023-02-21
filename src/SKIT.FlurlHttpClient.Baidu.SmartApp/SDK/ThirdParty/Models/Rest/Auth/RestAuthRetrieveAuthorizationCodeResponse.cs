namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/auth/retrieve/authorizationcode 接口的响应。</para>
    /// </summary>
    public class RestAuthRetrieveAuthorizationCodeResponse : BaiduSmartAppThirdPartyResponse<RestAuthRetrieveAuthorizationCodeResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置授权码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authorization_code")]
                [System.Text.Json.Serialization.JsonPropertyName("authorization_code")]
                public string AuthorizationCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置授权码有效期（单位：秒）
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expires_in")]
                [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
                public int ExpiresIn { get; set; }
            }
        }
    }
}
