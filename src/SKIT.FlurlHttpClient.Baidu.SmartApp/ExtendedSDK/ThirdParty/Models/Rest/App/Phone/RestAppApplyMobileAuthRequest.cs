namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/app/apply/mobileauth 接口的请求。</para>
    /// </summary>
    public class RestAppApplyMobileAuthRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置原因类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public int ReasonType { get; set; }

        /// <summary>
        /// 获取或设置场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("used_scene")]
        [System.Text.Json.Serialization.JsonPropertyName("used_scene")]
        public int Scene { get; set; }

        /// <summary>
        /// 获取或设置场景描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_desc")]
        public string SceneDescription { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置场景实例图片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_demo")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_demo")]
        public string SceneDemoUrl { get; set; } = string.Empty;
    }
}
