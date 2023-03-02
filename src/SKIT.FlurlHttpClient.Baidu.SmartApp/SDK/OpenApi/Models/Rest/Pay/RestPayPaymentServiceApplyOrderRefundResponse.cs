namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/pay/paymentservice/applyOrderRefund 接口的响应。</para>
    /// </summary>
    public class RestPayPaymentServiceApplyOrderRefundResponse : BaiduSmartAppOpenApiResponse<RestPayPaymentServiceApplyOrderRefundResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置退款批次 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refundBatchId")]
                [System.Text.Json.Serialization.JsonPropertyName("refundBatchId")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long RefundBatchId { get; set; }

                /// <summary>
                /// 获取或设置可退金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refundPayMoney")]
                [System.Text.Json.Serialization.JsonPropertyName("refundPayMoney")]
                public int RefundPayAmount { get; set; }
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public override string? ErrorMessage { get; set; }
    }
}
