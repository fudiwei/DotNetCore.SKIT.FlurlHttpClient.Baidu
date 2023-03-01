namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Events
{
    /// <summary>
    /// <para>表示 AUDIT_SUB_CHAIN_FAILED 事件的数据。</para>
    /// <para>REF: https://smartprogram.baidu.com/docs/third/info/info_push/ </para>
    /// </summary>
    public class AuditSubchainFailEvent : BaiduSmartAppThirdPartyEvent
    {
        /// <summary>
        /// 获取或设置子链 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subchainId")]
        [System.Text.Json.Serialization.JsonPropertyName("subchainId")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long SubchainId { get; set; }

        /// <summary>
        /// 获取或设置审核失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? RejectReason { get; set; }
    }
}
