namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Events
{
    /// <summary>
    /// <para>表示 ADVANCED_AUDIT_CHANGED 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://smartprogram.baidu.com/docs/third/advanced_auth/advanced_auth_push/ ]]>
    /// </para>
    /// </summary>
    public class AdvancedAuditChangedEvent : BaiduSmartAppThirdPartyEvent
    {
        /// <summary>
        /// 获取或设置认证类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adType")]
        [System.Text.Json.Serialization.JsonPropertyName("adType")]
        public int AdType { get; set; }

        /// <summary>
        /// 获取或设置认证状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adStatus")]
        [System.Text.Json.Serialization.JsonPropertyName("adStatus")]
        public int AdStatus { get; set; }
    }
}
