using System;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/pay/paymentservice/financeexpense 接口的响应。</para>
    /// </summary>
    public class RestPayPaymentServiceFinanceExpenseResponse : BaiduSmartAppThirdPartyResponse<RestPayPaymentServiceFinanceExpenseResponse.Types.Data>
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
                        [Newtonsoft.Json.JsonProperty("money")]
                        [System.Text.Json.Serialization.JsonPropertyName("money")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public decimal Amount { get; set; }

                        /// <summary>
                        /// 获取或设置类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("type_id")]
                        public string Type { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置打款状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_status")]
                        public string PayStatus { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置支付凭证 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("task_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long TaskId { get; set; }

                        /// <summary>
                        /// 获取或设置账期开始时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("start_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
                        public DateTimeOffset StartTime { get; set; }

                        /// <summary>
                        /// 获取或设置账期结束时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
                        public DateTimeOffset EndTime { get; set; }

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
                /// 获取或设置支出次数总和。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expense_count")]
                [System.Text.Json.Serialization.JsonPropertyName("expense_count")]
                public int ExpenseCount { get; set; }

                /// <summary>
                /// 获取或设置支出总金额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expense_money")]
                [System.Text.Json.Serialization.JsonPropertyName("expense_money")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public decimal ExpenseAmount { get; set; }

                /// <summary>
                /// 获取或设置支出明细列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data")]
                [System.Text.Json.Serialization.JsonPropertyName("data")]
                public Types.Record[] RecordList { get; set; } = default!;

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
