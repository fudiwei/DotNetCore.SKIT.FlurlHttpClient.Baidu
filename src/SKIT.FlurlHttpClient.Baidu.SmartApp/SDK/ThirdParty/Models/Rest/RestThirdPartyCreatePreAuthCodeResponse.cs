namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/tp/createpreauthcode 接口的响应。</para>
    /// </summary>
    public class RestThirdPartyCreatePreAuthCodeResponse : BaiduSmartAppThirdPartyResponse<RestThirdPartyCreatePreAuthCodeResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置预授权码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pre_auth_code")]
                [System.Text.Json.Serialization.JsonPropertyName("pre_auth_code")]
                public string PreAuthCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置预授权码有效期（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expires_in")]
                [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
                public int ExpiresIn { get; set; }
            }
        }
    }
}
