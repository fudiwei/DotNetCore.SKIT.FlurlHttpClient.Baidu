using System;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/pay/paymentservice/financebalance/otherdetail 接口的响应。</para>
    /// </summary>
    public class RestPayPaymentServiceFinanceBalanceOtherDetailResponse : BaiduSmartAppThirdPartyResponse<RestPayPaymentServiceFinanceBalanceOtherDetailResponse.Types.Data>
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
                        /// 获取或设置操作类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("opt_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("opt_type")]
                        public string OperateType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置金额（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ref_money")]
                        [System.Text.Json.Serialization.JsonPropertyName("ref_money")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public decimal Amount { get; set; }

                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long OrderId { get; set; }

                        /// <summary>
                        /// 获取或设置开发者自定义订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("third_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("third_order_id")]
                        public string OutOrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置操作时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("operate_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("operate_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
                        public DateTimeOffset OperateTime { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置入账金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public decimal TotalAmount { get; set; }

                /// <summary>
                /// 获取或设置货款总额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("order_amount")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public decimal OrderAmount { get; set; }

                /// <summary>
                /// 获取或设置规则类型 JSON 字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rule_type")]
                [System.Text.Json.Serialization.JsonPropertyName("rule_type")]
                public string? RuleTypeJson { get; set; }

                /// <summary>
                /// 获取或设置账单周期开始日期字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settlement_start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("settlement_start_time")]
                public string SettlementStartDateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置账单周期结束日期字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settlement_end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("settlement_end_time")]
                public string SettlementEndDateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置支付收入其他款项明细列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data")]
                [System.Text.Json.Serialization.JsonPropertyName("data")]
                public Types.Record[] RecordList { get; set; } = default!;
            }
        }
    }
}
