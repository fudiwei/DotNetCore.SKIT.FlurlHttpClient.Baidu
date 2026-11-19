namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Events
{
    /// <summary>
    /// <para>表示 "APP_FORCE_OFFLINE" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://smartprogram.baidu.com/docs/third/offline/statuspush/ ]]>
    /// </para>
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
        public string? OfflineReason { get; set; }

        /// <summary>
        /// 获取或设置非法字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("illegalFields")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedStringListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("illegalFields")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedStringListWithCommaSplitConverter))]
        public List<string>? IllegalFieldList { get; set; }
    }
}
