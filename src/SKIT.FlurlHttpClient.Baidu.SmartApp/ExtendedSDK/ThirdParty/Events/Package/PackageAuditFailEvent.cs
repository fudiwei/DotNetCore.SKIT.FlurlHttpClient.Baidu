namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Events
{
    /// <summary>
    /// <para>表示 PACKAGE_AUDIT_FAIL 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://smartprogram.baidu.com/docs/third/package/push/ ]]>
    /// </para>
    /// </summary>
    public class PackageAuditFailEvent : BaiduSmartAppThirdPartyEvent
    {
        /// <summary>
        /// 获取或设置代码包 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("packageId")]
        [System.Text.Json.Serialization.JsonPropertyName("packageId")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long PackageId { get; set; }

        /// <summary>
        /// 获取或设置代码包版本号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("packageVersion")]
        [System.Text.Json.Serialization.JsonPropertyName("packageVersion")]
        public string PackageVersion { get; set; } = default!;

        /// <summary>
        /// 获取或设置审核失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? RejectReason { get; set; }
    }
}
