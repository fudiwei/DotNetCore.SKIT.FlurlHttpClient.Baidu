namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/getsessionkey 接口的响应。</para>
    /// </summary>
    public class RestGetSessionKeyResponse : BaiduSmartAppOpenApiResponse<RestGetSessionKeyResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置用户身份标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_id")]
                [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户登录态密钥。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("session_key")]
                [System.Text.Json.Serialization.JsonPropertyName("session_key")]
                public string SessionKey { get; set; } = default!;
            }
        }
    }
}
