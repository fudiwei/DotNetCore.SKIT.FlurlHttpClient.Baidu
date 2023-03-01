using System;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/pay/paymentservice/orderlist 接口的响应。</para>
    /// </summary>
    public class RestPayPaymentServiceOrderListResponse : BaiduSmartAppThirdPartyResponse<RestPayPaymentServiceOrderListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Order
                    {
                        /// <summary>
                        /// 获取或设置开发者自定义订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tp_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("tp_order_id")]
                        public string OutOrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long OrderId { get; set; }

                        /// <summary>
                        /// 获取或设置百度收银台的财务结算凭证。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("deal_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("deal_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string? DealId { get; set; }

                        /// <summary>
                        /// 获取或设置订单商品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("deal_title")]
                        [System.Text.Json.Serialization.JsonPropertyName("deal_title")]
                        public string? DealTitle { get; set; }

                        /// <summary>
                        /// 获取或设置支付渠道。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("channel")]
                        [System.Text.Json.Serialization.JsonPropertyName("channel")]
                        public string? Channel { get; set; }

                        /// <summary>
                        /// 获取或设置用户手机号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("phone")]
                        [System.Text.Json.Serialization.JsonPropertyName("phone")]
                        public string? PhoneNumber { get; set; }

                        /// <summary>
                        /// 获取或设置支付金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_money")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_money")]
                        public int PayAmount { get; set; }

                        /// <summary>
                        /// 获取或设置订单金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_money")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_money")]
                        public int TotalAmount { get; set; }

                        /// <summary>
                        /// 获取或设置已退款金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("segment_refunded_money")]
                        [System.Text.Json.Serialization.JsonPropertyName("segment_refunded_money")]
                        public int? RefundedAmount { get; set; }

                        /// <summary>
                        /// 获取或设置订单子状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sub_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("sub_status")]
                        public int SubStatus { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                        public DateTimeOffset CreateTime { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                        public DateTimeOffset UpdateTime { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data")]
                [System.Text.Json.Serialization.JsonPropertyName("data")]
                public Types.Order[] OrderList { get; set; } = default!;

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

                /// <summary>
                /// 获取或设置总页数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_page")]
                [System.Text.Json.Serialization.JsonPropertyName("total_page")]
                public int TotalPage { get; set; }
            }
        }
    }
}
