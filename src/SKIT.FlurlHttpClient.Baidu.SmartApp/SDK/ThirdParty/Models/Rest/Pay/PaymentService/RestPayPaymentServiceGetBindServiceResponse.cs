namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/pay/paymentservice/getbindservice 接口的响应。</para>
    /// </summary>
    public class RestPayPaymentServiceGetBindServiceResponse : BaiduSmartAppThirdPartyResponse<RestPayPaymentServiceGetBindServiceResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置支付服务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pm_app_id")]
                [System.Text.Json.Serialization.JsonPropertyName("pm_app_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ServiceAppId { get; set; }

                /// <summary>
                /// 获取或设置支付服务 AppKey。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pm_app_key")]
                [System.Text.Json.Serialization.JsonPropertyName("pm_app_key")]
                public string ServiceAppKey { get; set; } = default!;

                /// <summary>
                /// 获取或设置服务名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_name")]
                [System.Text.Json.Serialization.JsonPropertyName("app_name")]
                public string ServiceAppName { get; set; } = default!;

                /// <summary>
                /// 获取或设置服务电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("service_phone")]
                public string ServicePhoneNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置银行开户名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_account")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_account")]
                public string BankAccountName { get; set; } = default!;

                /// <summary>
                /// 获取或设置银行卡号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_card")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_card")]
                public string BankAccountNumber { get; set; } = default!;

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
                public string BankName { get; set; } = default!;

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

                /// <summary>
                /// 获取或设置平台公钥。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("platform_public_key")]
                [System.Text.Json.Serialization.JsonPropertyName("platform_public_key")]
                public string PlatformPublicKey { get; set; } = default!;

                /// <summary>
                /// 获取或设置百度收银台的财务结算凭证。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deal_id")]
                [System.Text.Json.Serialization.JsonPropertyName("deal_id")]
                public string DealId { get; set; } = default!;

                /// <summary>
                /// 获取或设置开通状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_status")]
                [System.Text.Json.Serialization.JsonPropertyName("open_status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置审核拒绝原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
                public string? RejectReason { get; set; }
            }
        }
    }
}
