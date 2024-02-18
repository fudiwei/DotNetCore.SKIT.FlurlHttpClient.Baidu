namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/pay/paymentservice/create 接口的请求。</para>
    /// </summary>
    public class RestPayPaymentServiceCreateRequest : BaiduSmartAppThirdPartyRequest
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
        /// 获取或设置银行开户名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_account")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_account")]
        public string BankAccountName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置银行卡号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_card")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_card")]
        public string BankAccountNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置银行卡预留手机号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_phone_number")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_phone_number")]
        public string? BankAcountPhoneNumber { get; set; }

        /// <summary>
        /// 获取或设置银行名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_name")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_name")]
        public string BankName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置银行支行名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_branch")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_branch")]
        public string? BankBranchName { get; set; }

        /// <summary>
        /// 获取或设置开户行省份。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_province")]
        [System.Text.Json.Serialization.JsonPropertyName("open_province")]
        public string? BankProvince { get; set; }

        /// <summary>
        /// 获取或设置开户行城市。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_city")]
        [System.Text.Json.Serialization.JsonPropertyName("open_city")]
        public string? BankCity { get; set; }

        /// <summary>
        /// 获取或设置佣金比例（单位：千分数）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commission_rate")]
        [System.Text.Json.Serialization.JsonPropertyName("commission_rate")]
        public int CommissionRate { get; set; }

        /// <summary>
        /// 获取或设置结算周期（单位：天）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_days")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_days")]
        public int PaymentDays { get; set; }

        /// <summary>
        /// 获取或设置提现后的保留金额（单位：元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pool_cash_pledge")]
        [System.Text.Json.Serialization.JsonPropertyName("pool_cash_pledge")]
        public int PoolCashPledgeAmount { get; set; }

        /// <summary>
        /// 获取或设置每日退款上限金额（单位：元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("day_max_frozen_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("day_max_frozen_amount")]
        public int DailyMaxFrozenAmount { get; set; }
    }
}
