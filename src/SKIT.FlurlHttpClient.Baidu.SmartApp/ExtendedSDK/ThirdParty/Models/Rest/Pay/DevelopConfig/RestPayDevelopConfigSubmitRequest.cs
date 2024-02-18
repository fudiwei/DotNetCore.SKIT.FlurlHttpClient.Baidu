namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/pay/developconfig/submit 接口的请求。</para>
    /// </summary>
    public class RestPayDevelopConfigSubmitRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置开发者公钥。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tp_public_key")]
        [System.Text.Json.Serialization.JsonPropertyName("tp_public_key")]
        public string ThirdPartyPublicKey { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置支付回调地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_notify_url")]
        public string PayNotifyUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置退款审核地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_audit_url")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_audit_url")]
        public string RefundAuditUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置退款回调地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_succ_url")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_succ_url")]
        public string RefundNotifyUrl { get; set; } = string.Empty;
    }
}
