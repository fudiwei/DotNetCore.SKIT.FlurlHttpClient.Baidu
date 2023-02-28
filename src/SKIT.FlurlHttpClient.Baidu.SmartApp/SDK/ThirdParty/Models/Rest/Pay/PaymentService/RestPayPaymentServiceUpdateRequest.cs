namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/pay/paymentservice/update 接口的请求。</para>
    /// </summary>
    public class RestPayPaymentServiceUpdateRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置服务名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_name")]
        [System.Text.Json.Serialization.JsonPropertyName("app_name")]
        public string ServiceAppName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置服务电话。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("service_phone")]
        public string ServicePhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置提现后的保留金额（单位：元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pool_cash_pledge")]
        [System.Text.Json.Serialization.JsonPropertyName("pool_cash_pledge")]
        public int PoolCashPledgeAmount { get; set; }
    }
}
