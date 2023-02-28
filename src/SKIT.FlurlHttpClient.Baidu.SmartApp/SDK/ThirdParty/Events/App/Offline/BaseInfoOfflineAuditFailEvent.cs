namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Events
{
    /// <summary>
    /// <para>表示 BASE_INFO_OFFLINE_AUDIT_FAIL 事件的数据。</para>
    /// <para>REF: https://smartprogram.baidu.com/docs/third/offline/updateinfo/ </para>
    /// </summary>
    public class BaseInfoOfflineAuditFailEvent : BaiduSmartAppThirdPartyEvent
    {
        /// <summary>
        /// 获取或设置审核 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("examineId")]
        [System.Text.Json.Serialization.JsonPropertyName("examineId")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long ExamineId { get; set; }

        /// <summary>
        /// 获取或设置审核失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? RejectReason { get; set; }
    }
}
