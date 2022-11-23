using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.Auth
{
    public class FaceAuthenResponse : SmartAppResponse<AuthFaceAuthenResponseData>
    {
    }

    public class AuthFaceAuthenResponseData
    {
        /// <summary>
        /// 二维码(base64编码图片)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcode")]
        [System.Text.Json.Serialization.JsonPropertyName("qrcode")]
        public string QrCode { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timeout")]
        [System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public string Timeout { get; set; }

        /// <summary>
        /// 认证任务状态(1：初始化；2：通过；4：拒绝；6：进行中)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("legal_face_status")]
        [System.Text.Json.Serialization.JsonPropertyName("legal_face_status")]
        public string LegalFaceStatus { get; set; }
    }
}
