namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Events
{
    /// <summary>
    /// <para>表示 BASE_INFO_OFFLINE_AUDIT_SUCCESS 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://smartprogram.baidu.com/docs/third/offline/updateinfo/ ]]>
    /// </para>
    /// </summary>
    public class BaseInfoOfflineAuditSuccessEvent : BaiduSmartAppThirdPartyEvent
    {
        /// <summary>
        /// 获取或设置审核 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("examineId")]
        [System.Text.Json.Serialization.JsonPropertyName("examineId")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long ExamineId { get; set; }
    }
}
