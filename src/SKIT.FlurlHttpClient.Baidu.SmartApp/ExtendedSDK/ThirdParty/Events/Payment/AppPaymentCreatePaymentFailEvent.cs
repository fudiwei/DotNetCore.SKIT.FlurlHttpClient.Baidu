namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Events
{
    /// <summary>
    /// <para>表示 APP_PAYMENT_CREATE_PAYMENT_FAIL 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://smartprogram.baidu.com/docs/third/pay/auditcallback/ ]]>
    /// </para>
    /// </summary>
    public class AppPaymentCreatePaymentFailEvent : BaiduSmartAppThirdPartyEvent
    {
        /// <summary>
        /// 获取或设置审核失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? RejectReason { get; set; }
    }
}
