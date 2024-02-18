namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Events
{
    /// <summary>
    /// <para>表示 APPLY_APP_MOBILE_AUTH_REJECT 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://smartprogram.baidu.com/docs/third/phone/phone_push/ ]]>
    /// </para>
    /// </summary>
    public class ApplyAppMobileAuthRejectEvent : BaiduSmartAppThirdPartyEvent
    {
        /// <summary>
        /// 获取或设置审核失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? RejectReason { get; set; }
    }
}
