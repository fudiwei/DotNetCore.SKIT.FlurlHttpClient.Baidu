using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.Auth
{
    public class PaymentCertificationResponse : SmartAppResponse<PaymentCertificationResponseData>
    {
    }

    public class PaymentCertificationResponseData
    {
        /// <summary>
        /// 认证页面调起url
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
