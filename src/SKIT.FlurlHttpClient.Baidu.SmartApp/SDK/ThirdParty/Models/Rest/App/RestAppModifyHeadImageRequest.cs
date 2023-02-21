namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/app/modifyheadimage 接口的请求。</para>
    /// </summary>
    public class RestAppModifyHeadImageRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置头像文件 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_url")]
        [System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string ImageUrl { get; set; } = string.Empty;
    }
}
