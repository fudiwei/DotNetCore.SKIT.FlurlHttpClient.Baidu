namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/pay/paymentservice/tp/findOrderRefund 接口的响应。</para>
    /// </summary>
    public class RestPayPaymentServiceThirdPartyFindOrderRefundResponse : BaiduSmartAppThirdPartyResponse<RestPayPaymentServiceThirdPartyFindOrderRefundResponse.Types.Refund[]>
    {
        public static class Types
        {
            public class Refund
            {
                /// <summary>
                /// 获取或设置退款批次 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refundBatchId")]
                [System.Text.Json.Serialization.JsonPropertyName("refundBatchId")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long RefundBatchId { get; set; }

                /// <summary>
                /// 获取或设置开发者自定义退款批次 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bizRefundBatchId")]
                [System.Text.Json.Serialization.JsonPropertyName("bizRefundBatchId")]
                public string OutRefundBatchId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("orderId")]
                [System.Text.Json.Serialization.JsonPropertyName("orderId")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long OrderId { get; set; }

                /// <summary>
                /// 获取或设置退款状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refundStatus")]
                [System.Text.Json.Serialization.JsonPropertyName("refundStatus")]
                public int RefundStatus { get; set; }

                /// <summary>
                /// 获取或设置百度收银台用户 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userId")]
                [System.Text.Json.Serialization.JsonPropertyName("userId")]
                public long UserId { get; set; }
            }
        }
    }
}
