namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Events
{
    /// <summary>
    /// <para>表示 PACKAGE_AUDIT_PASS 事件的数据。</para>
    /// <para>REF: https://smartprogram.baidu.com/docs/third/package/push/ </para>
    /// </summary>
    public class PackageAuditPassEvent : BaiduSmartAppThirdPartyEvent
    {
        /// <summary>
        /// 获取或设置代码包 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("packageId")]
        [System.Text.Json.Serialization.JsonPropertyName("packageId")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long PackageId { get; set; } = default!;

        /// <summary>
        /// 获取或设置代码包版本号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("packageVersion")]
        [System.Text.Json.Serialization.JsonPropertyName("packageVersion")]
        public string PackageVersion { get; set; } = default!;
    }
}
