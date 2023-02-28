namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/pay/paymentservice/financeexpense/paydetail 接口的请求。</para>
    /// </summary>
    public class RestPayPaymentServiceFinanceExpensePayDetailRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置支付凭证 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long TaskId { get; set; }
    }
}
