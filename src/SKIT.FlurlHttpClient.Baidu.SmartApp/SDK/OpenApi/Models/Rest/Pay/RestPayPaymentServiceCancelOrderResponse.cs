namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/pay/paymentservice/cancelOrder 接口的响应。</para>
    /// </summary>
    public class RestPayPaymentServiceCancelOrderResponse : BaiduSmartAppOpenApiResponse
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public override string? ErrorMessage { get; set; }
    }
}
