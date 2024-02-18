using System;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/pay/paymentservice/financebalance/incomedetail 接口的响应。</para>
    /// </summary>
    public class RestPayPaymentServiceFinanceBalanceIncomeDetailResponse : BaiduSmartAppThirdPartyResponse<RestPayPaymentServiceFinanceBalanceIncomeDetailResponse.Types.Data>
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
                        [Newtonsoft.Json.JsonProperty("money")]
                        [System.Text.Json.Serialization.JsonPropertyName("money")]
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
                /// 获取或设置验证/成交数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quantity")]
                [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                public int Quantity { get; set; }

                /// <summary>
                /// 获取或设置货款（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("income")]
                [System.Text.Json.Serialization.JsonPropertyName("income")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public decimal Income { get; set; }

                /// <summary>
                /// 获取或设置验证/成交总额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("income_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("income_amount")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public decimal IncomeAmount { get; set; }

                /// <summary>
                /// 获取或设置退款总额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public decimal RefundAmount { get; set; }

                /// <summary>
                /// 获取或设置操作日期字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("operate_time")]
                [System.Text.Json.Serialization.JsonPropertyName("operate_time")]
                public string OperateDateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置支付收入货款明细列表。
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
