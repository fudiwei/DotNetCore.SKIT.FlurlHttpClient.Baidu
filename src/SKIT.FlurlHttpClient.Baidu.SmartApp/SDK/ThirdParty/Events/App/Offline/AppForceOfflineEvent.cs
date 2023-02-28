namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Events
{
    /// <summary>
    /// <para>表示 APP_FORCE_OFFLINE 事件的数据。</para>
    /// <para>REF: https://smartprogram.baidu.com/docs/third/offline/statuspush/ </para>
    /// </summary>
    public class AppForceOfflineEvent : BaiduSmartAppThirdPartyEvent
    {
        /// <summary>
        /// 获取或设置强制下线原因类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offlineReason")]
        [System.Text.Json.Serialization.JsonPropertyName("offlineReason")]
        public int OfflineReasonType { get; set; }

        /// <summary>
        /// 获取或设置强制下线原因描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string OfflineReason { get; set; } = default!;

        /// <summary>
        /// 获取或设置非法字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("illegalFields")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringArrayWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("illegalFields")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringArrayWithCommaSplitConverter))]
        public string[]? IllegalFieldList { get; set; }
    }
}
