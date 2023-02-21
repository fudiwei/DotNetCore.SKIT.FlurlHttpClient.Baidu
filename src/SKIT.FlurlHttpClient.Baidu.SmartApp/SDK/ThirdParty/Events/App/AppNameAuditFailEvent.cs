namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Events
{
    /// <summary>
    /// <para>表示 APP_NAME_AUDIT_FAIL 事件的数据。</para>
    /// <para>REF: https://smartprogram.baidu.com/docs/third/info/info_push/ </para>
    /// </summary>
    public class AppNameAuditFailEvent : BaiduSmartAppThirdPartyEvent
    {
        /// <summary>
        /// 获取或设置小程序名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AppName")]
        [System.Text.Json.Serialization.JsonPropertyName("AppName")]
        public string AppName { get; set; } = default!;

        /// <summary>
        /// 获取或设置审核失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? RejectReason { get; set; }
    }
}
