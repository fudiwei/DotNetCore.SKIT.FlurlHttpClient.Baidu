namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /oauth/2.0/token 接口的请求。</para>
    /// </summary>
    public class OAuthTokenRequest : BaiduSmartAppOpenApiRequest
    {
        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string GrantType { get; set; } = "client_credential";

        /// <summary>
        /// 获取或设置权限。
        /// <para>默认值：smartapp_snsapi_base</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Scope { get; set; } = "smartapp_snsapi_base";
    }
}
