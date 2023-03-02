namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/pay/paymentservice/applyOrderRefund 接口的请求。</para>
    /// </summary>
    public class RestPayPaymentServiceApplyOrderRefundRequest : BaiduSmartAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置支付服务 AppKey。如果不指定将使用构造 <see cref="BaiduSmartAppThirdPartyClient"/> 时的 <see cref="BaiduSmartAppThirdPartyClientOptions.PaymentServiceAppKey"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pmAppKey")]
        [System.Text.Json.Serialization.JsonPropertyName("pmAppKey")]
        public string? PaymentServiceAppKey { get; set; }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orderId")]
        [System.Text.Json.Serialization.JsonPropertyName("orderId")]
        public long OrderId { get; set; }

        /// <summary>
        /// 获取或设置开发者自定义订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tpOrderId")]
        [System.Text.Json.Serialization.JsonPropertyName("tpOrderId")]
        public string OutOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置开发者自定义退款批次 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bizRefundBatchId")]
        [System.Text.Json.Serialization.JsonPropertyName("bizRefundBatchId")]
        public string OutRefundBatchId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置退款金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applyRefundMoney")]
        [System.Text.Json.Serialization.JsonPropertyName("applyRefundMoney")]
        public int RefundAmount { get; set; }

        /// <summary>
        /// 获取或设置退款金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("isSkipAudit")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("isSkipAudit")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsSkipAudit { get; set; }

        /// <summary>
        /// 获取或设置退款类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refundType")]
        [System.Text.Json.Serialization.JsonPropertyName("refundType")]
        public int RefundType { get; set; }

        /// <summary>
        /// 获取或设置退款原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refundReason")]
        [System.Text.Json.Serialization.JsonPropertyName("refundReason")]
        public string RefundReason { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置百度收银台用户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId")]
        [System.Text.Json.Serialization.JsonPropertyName("userId")]
        public long UserId { get; set; }

        /// <summary>
        /// 获取或设置退款消息推送 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refundNotifyUrl")]
        [System.Text.Json.Serialization.JsonPropertyName("refundNotifyUrl")]
        public string? RefundNotifyUrl { get; set; }
    }
}
