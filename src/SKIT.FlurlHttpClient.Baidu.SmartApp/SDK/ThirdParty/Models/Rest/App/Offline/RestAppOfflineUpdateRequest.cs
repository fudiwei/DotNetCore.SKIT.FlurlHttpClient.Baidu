namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/app/offline/update 接口的请求。</para>
    /// </summary>
    public class RestAppOfflineUpdateRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置小程序名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_name")]
        [System.Text.Json.Serialization.JsonPropertyName("app_name")]
        public string? AppName { get; set; }

        /// <summary>
        /// 获取或设置小程序名称相关物料。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_name_material")]
        [System.Text.Json.Serialization.JsonPropertyName("app_name_material")]
        public string? AppNameMaterial { get; set; }

        /// <summary>
        /// 获取或设置小程序介绍。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("app_desc")]
        public string? AppDescription { get; set; }

        /// <summary>
        /// 获取或设置小程序头像 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("photo_addr")]
        [System.Text.Json.Serialization.JsonPropertyName("photo_addr")]
        public string? HeadImageUrl { get; set; }
    }
}
