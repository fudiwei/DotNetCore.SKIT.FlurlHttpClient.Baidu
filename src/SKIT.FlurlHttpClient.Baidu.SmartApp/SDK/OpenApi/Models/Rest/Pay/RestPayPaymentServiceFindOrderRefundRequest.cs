namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/pay/paymentservice/findOrderRefund 接口的请求。</para>
    /// </summary>
    public class RestPayPaymentServiceFindOrderRefundRequest : BaiduSmartAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置支付服务 AppKey。如果不指定将使用构造 <see cref="BaiduSmartAppThirdPartyClient"/> 时的 <see cref="BaiduSmartAppThirdPartyClientOptions.PaymentServiceAppKey"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? PaymentServiceAppKey { get; set; }

        /// <summary>
        /// 获取或设置开发者自定义订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置百度收银台用户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long UserId { get; set; }
    }
}
