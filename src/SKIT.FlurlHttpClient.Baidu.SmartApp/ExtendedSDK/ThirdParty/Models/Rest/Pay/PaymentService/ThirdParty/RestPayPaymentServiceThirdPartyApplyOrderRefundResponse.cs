namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/pay/paymentservice/tp/applyOrderRefund 接口的响应。</para>
    /// </summary>
    public class RestPayPaymentServiceThirdPartyApplyOrderRefundResponse : BaiduSmartAppThirdPartyResponse<RestPayPaymentServiceThirdPartyApplyOrderRefundResponse.Types.Data>
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
    }
}
