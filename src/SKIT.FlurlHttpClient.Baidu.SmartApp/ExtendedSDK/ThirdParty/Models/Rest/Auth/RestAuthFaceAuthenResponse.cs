namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/auth/faceauthen 接口的响应。</para>
    /// </summary>
    public class RestAuthFaceAuthenResponse : BaiduSmartAppThirdPartyResponse<RestAuthFaceAuthenResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置经过 Base64 编码的二维码图片数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qrcode")]
                [System.Text.Json.Serialization.JsonPropertyName("qrcode")]
                public string EncodingQrcodeData { get; set; } = default!;

                /// <summary>
                /// 获取或设置二维码过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("timeout")]
                [System.Text.Json.Serialization.JsonPropertyName("timeout")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ExpireTimestamp { get; set; }

                /// <summary>
                /// 获取或设置认证任务状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("legal_face_status")]
                [System.Text.Json.Serialization.JsonPropertyName("legal_face_status")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int LegalFaceStatus { get; set; }
            }
        }
    }
}
