using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.Auth
{
    public class CreatePreAuthCodeResponse : SmartAppResponse<CreatePreAuthCodeResponseData>
    {
    }

    public class CreatePreAuthCodeResponseData
    {
        /// <summary>
        /// 预授权码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pre_auth_code")]
        [System.Text.Json.Serialization.JsonPropertyName("pre_auth_code")]
        public string PreAuthCode { get; set; }

        /// <summary>
        /// 凭证有效时间，单位：秒，默认20分钟
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires_in")]
        [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }
    }
}
