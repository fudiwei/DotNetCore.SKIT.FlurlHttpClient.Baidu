namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/getsessionkey 接口的请求。</para>
    /// </summary>
    public class RestGetSessionKeyRequest : BaiduSmartAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置授权类型。
        /// <para>默认值："authorization_code"</para>
        /// <remarks><i>（使用默认值即可，无需修改）</i></remarks>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? GrantType { get; set; } = "authorization_code";

        /// <summary>
        /// 获取或设置小程序登录授权码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Code { get; set; }
    }
}
