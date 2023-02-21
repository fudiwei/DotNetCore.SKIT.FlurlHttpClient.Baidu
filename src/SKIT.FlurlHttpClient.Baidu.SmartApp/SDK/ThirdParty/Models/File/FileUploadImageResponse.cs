namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /file/2.0/smartapp/upload/image 接口的响应。</para>
    /// </summary>
    public class FileUploadImageResponse : BaiduSmartAppThirdPartyResponse
    {
        /// <summary>
        /// 获取或设置文件 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public string FileUrl { get; set; } = default!;
    }
}
