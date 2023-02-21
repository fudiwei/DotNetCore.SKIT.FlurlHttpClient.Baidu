namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty
{
    /// <summary>
    /// 表示百度智能小程序第三方平台 API 消息推送事件的基类。
    /// </summary>
    public class BaiduSmartAppThirdPartyEvent
    {
        /// <summary>
        /// 获取或设置第三方平台 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tpAppId")]
        [System.Text.Json.Serialization.JsonPropertyName("tpAppId")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
        public virtual string? ThirdPartyAppId { get; set; }

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appId")]
        [System.Text.Json.Serialization.JsonPropertyName("appId")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
        public virtual string? AppId { get; set; }

        /// <summary>
        /// 获取或设置事件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("event")]
        [System.Text.Json.Serialization.JsonPropertyName("event")]
        public virtual string Event { get; set; } = default!;

        /// <summary>
        /// 获取或设置事件产生时间字符串（格式：yyyy-MM-dd HH:mm:ss）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("eventTime")]
        [System.Text.Json.Serialization.JsonPropertyName("eventTime")]
        public virtual string? EventTimeString { get; set; }
    }
}
