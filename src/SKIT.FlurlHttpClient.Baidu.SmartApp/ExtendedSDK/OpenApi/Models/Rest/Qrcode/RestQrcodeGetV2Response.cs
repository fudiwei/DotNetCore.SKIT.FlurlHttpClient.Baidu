namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/qrcode/getv2 接口的响应。</para>
    /// </summary>
    public class RestQrcodeGetV2Response : BaiduSmartAppOpenApiResponse<RestQrcodeGetV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置经 Base64 编码的二维码图片数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base64_str")]
                [System.Text.Json.Serialization.JsonPropertyName("base64_str")]
                public string? EncodingQrcodeData { get; set; }

                /// <summary>
                /// 获取或设置二维码 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string? QrcodeUrl { get; set; }
            }
        }
    }
}
