using System;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/pay/paymentservice/financebalance 接口的响应。</para>
    /// </summary>
    public class RestPayPaymentServiceFinanceBalanceResponse : BaiduSmartAppThirdPartyResponse<RestPayPaymentServiceFinanceBalanceResponse.Types.Data>
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
                        /// 获取或设置货款金额（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("income")]
                        [System.Text.Json.Serialization.JsonPropertyName("income")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public decimal Income { get; set; }

                        /// <summary>
                        /// 获取或设置调整款项（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("adjust_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("adjust_amount")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public decimal AdjustAmount { get; set; }

                        /// <summary>
                        /// 获取或设置其他款项（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("others")]
                        [System.Text.Json.Serialization.JsonPropertyName("others")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public decimal OtherAmount { get; set; }

                        /// <summary>
                        /// 获取或设置操作时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("operate_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("operate_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                        public DateTimeOffset OperateTime { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置当前付款周期（单位：天）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("period")]
                [System.Text.Json.Serialization.JsonPropertyName("period")]
                public int Period { get; set; }

                /// <summary>
                /// 获取或设置货款总金额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("income")]
                [System.Text.Json.Serialization.JsonPropertyName("income")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public decimal Income { get; set; }

                /// <summary>
                /// 获取或设置调整款项总金额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("adjustment")]
                [System.Text.Json.Serialization.JsonPropertyName("adjustment")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public decimal AdjustAmount { get; set; }

                /// <summary>
                /// 获取或设置其他款项总金额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("others")]
                [System.Text.Json.Serialization.JsonPropertyName("others")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public decimal OtherAmount { get; set; }

                /// <summary>
                /// 获取或设置账户余额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("free_balance")]
                [System.Text.Json.Serialization.JsonPropertyName("free_balance")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public decimal FreeBalance { get; set; }

                /// <summary>
                /// 获取或设置支付日期字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payment_due")]
                [System.Text.Json.Serialization.JsonPropertyName("payment_due")]
                public string PaymentDueDateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置支付收入明细列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data")]
                [System.Text.Json.Serialization.JsonPropertyName("data")]
                public Types.Record[] RecordList { get; set; } = default!;

                /// <summary>
                /// 获取或设置当前页数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("current_page")]
                [System.Text.Json.Serialization.JsonPropertyName("current_page")]
                public int PageNumber { get; set; }

                /// <summary>
                /// 获取或设置当前每页数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_size")]
                [System.Text.Json.Serialization.JsonPropertyName("page_size")]
                public int PageSize { get; set; }

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                public int TotalCount { get; set; }
            }
        }
    }
}
