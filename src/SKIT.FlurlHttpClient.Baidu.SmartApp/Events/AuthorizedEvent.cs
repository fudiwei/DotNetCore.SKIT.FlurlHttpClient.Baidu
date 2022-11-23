using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Events
{
    /// <summary>
    /// 授权成功通知
    /// </summary>
    public class AuthorizedEvent : SmartAppEvent
    {
        /// <summary>
        /// 授权码可以换取小程序的接口调用凭据
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorizationCode")]
        [System.Text.Json.Serialization.JsonPropertyName("authorizationCode")]
        public string AuthorizationCode { get; set; }

        /// <summary>
        /// 授权码过期时间（单位：秒）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorizationCodeExpiresIn")]
        [System.Text.Json.Serialization.JsonPropertyName("authorizationCodeExpiresIn")]
        public int AuthorizationCodeExpiresIn { get; set; }
    }
}
