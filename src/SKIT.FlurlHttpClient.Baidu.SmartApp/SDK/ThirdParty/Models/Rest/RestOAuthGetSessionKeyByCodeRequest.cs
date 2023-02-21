namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/oauth/getsessionkeybycode 接口的请求。</para>
    /// </summary>
    public class RestOAuthGetSessionKeyByCodeRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置小程序登录授权码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string GrantType { get; set; } = "authorization_code";
    }
}
