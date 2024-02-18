namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Events
{
    /// <summary>
    /// <para>表示 APP_CATEGORY_AUDIT_PASS 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://smartprogram.baidu.com/docs/third/search/subchain/subchain_audit_result_push/ ]]>
    /// </para>
    /// </summary>
    public class AuditSubchainPassEvent : BaiduSmartAppThirdPartyEvent
    {
        /// <summary>
        /// 获取或设置子链 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subchainId")]
        [System.Text.Json.Serialization.JsonPropertyName("subchainId")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long SubchainId { get; set; }
    }
}
