namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/pay/paymentservice/capitaBill 接口的请求。</para>
    /// </summary>
    public class RestPayPaymentServiceCapitaBillRequest : BaiduSmartAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置支付服务 AppKey。如果不指定将使用构造 <see cref="BaiduSmartAppThirdPartyClient"/> 时的 <see cref="BaiduSmartAppThirdPartyClientOptions.PaymentServiceAppKey"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? PaymentServiceAppKey { get; set; }

        /// <summary>
        /// 获取或设置资金账单日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BillDateString { get; set; } = string.Empty;
    }
}
