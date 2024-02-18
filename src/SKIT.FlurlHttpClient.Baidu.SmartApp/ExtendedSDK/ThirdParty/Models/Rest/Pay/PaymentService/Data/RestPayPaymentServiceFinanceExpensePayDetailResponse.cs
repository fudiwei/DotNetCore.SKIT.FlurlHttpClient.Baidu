using System;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/pay/paymentservice/financeexpense/paydetail 接口的响应。</para>
    /// </summary>
    public class RestPayPaymentServiceFinanceExpensePayDetailResponse : BaiduSmartAppThirdPartyResponse<RestPayPaymentServiceFinanceExpensePayDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Record
                    {
                        /// <summary>
                        /// 获取或设置收款金额（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("paid_money")]
                        [System.Text.Json.Serialization.JsonPropertyName("paid_money")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public decimal Amount { get; set; }

                        /// <summary>
                        /// 获取或设置收款账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("paid_account")]
                        [System.Text.Json.Serialization.JsonPropertyName("paid_account")]
                        public string AccountNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置收款人姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("receive_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("receive_user")]
                        public string AccountName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置备注信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("remark")]
                        [System.Text.Json.Serialization.JsonPropertyName("remark")]
                        public string? Remark { get; set; }

                        /// <summary>
                        /// 获取或设置收款状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("payment_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("payment_status")]
                        public string PayStatus { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置支出打款明细列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data")]
                [System.Text.Json.Serialization.JsonPropertyName("data")]
                public Types.Record[] RecordList { get; set; } = default!;
            }
        }
    }
}
