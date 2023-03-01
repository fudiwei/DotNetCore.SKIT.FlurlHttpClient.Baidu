namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/qrcode/getv2 接口的请求。</para>
    /// </summary>
    public class RestQrcodeGetV2Request : BaiduSmartAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path")]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? PagePath { get; set; }

        /// <summary>
        /// 获取或设置二维码宽度（单位：像素）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("width")]
        [System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// 获取或设置内嵌 Logo 类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mf")]
        [System.Text.Json.Serialization.JsonPropertyName("mf")]
        public int? LogoType { get; set; }

        /// <summary>
        /// 获取或设置返回值类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("img_flag")]
        [System.Text.Json.Serialization.JsonPropertyName("img_flag")]
        public int? ResponseType { get; set; }
    }
}
