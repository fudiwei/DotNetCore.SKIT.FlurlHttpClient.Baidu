using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/ordercenter/app/update/main/info 接口的请求。</para>
    /// </summary>
    public class RestOrderCenterAppUpdateMainInfoRequest : BaiduSmartAppOpenApiRequest
    {
        public static class Types
        {
            public class Order : RestOrderCenterAppAddMainInfoRequest.Types.Order
            {
                public static new class Types
                {
                    public class ExtendedInfo : RestOrderCenterAppAddMainInfoRequest.Types.Order.Types.ExtendedInfo
                    {
                        public static new class Types
                        {
                            public class Order : RestOrderCenterAppAddMainInfoRequest.Types.Order.Types.ExtendedInfo.Types.Order
                            {
                                public static new class Types
                                {
                                    public class Product : RestOrderCenterAppAddMainInfoRequest.Types.Order.Types.ExtendedInfo.Types.Order.Types.Product
                                    {
                                        public static new class Types
                                        {
                                            public class SKUAttribute : RestOrderCenterAppAddMainInfoRequest.Types.Order.Types.ExtendedInfo.Types.Order.Types.Product.Types.SKUAttribute
                                            {
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置商品 SKU 属性列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("SkuAttr")]
                                        [System.Text.Json.Serialization.JsonPropertyName("SkuAttr")]
                                        public new IList<Types.SKUAttribute>? SKUAttributeList { get; set; }

                                        /// <summary>
                                        /// 获取或设置商品详情页配置信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("DetailPage")]
                                        [System.Text.Json.Serialization.JsonPropertyName("DetailPage")]
                                        public new DetailedPageInfo? ProductDetailPageInfo { get; set; }
                                    }

                                    public class Payment : RestOrderCenterAppAddMainInfoRequest.Types.Order.Types.ExtendedInfo.Types.Order.Types.Payment
                                    {
                                        public static new class Types
                                        {
                                            public class Item : RestOrderCenterAppAddMainInfoRequest.Types.Order.Types.ExtendedInfo.Types.Order.Types.Payment.Types.Item
                                            {
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置优惠信息列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("PreferentialInfo")]
                                        [System.Text.Json.Serialization.JsonPropertyName("PreferentialInfo")]
                                        public new IList<Types.Item>? PreferentialList { get; set; }

                                        /// <summary>
                                        /// 获取或设置付款信息列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("PaymentInfo")]
                                        [System.Text.Json.Serialization.JsonPropertyName("PaymentInfo")]
                                        public new IList<Types.Item>? PaymentList { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置商品列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Products")]
                                [System.Text.Json.Serialization.JsonPropertyName("Products")]
                                public new IList<Types.Product> ProductList { get; set; } = new List<Types.Product>();

                                /// <summary>
                                /// 获取或设置支付信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Payment")]
                                [System.Text.Json.Serialization.JsonPropertyName("Payment")]
                                public new Types.Payment Payment { get; set; } = new Types.Payment();

                                /// <summary>
                                /// 获取或设置订单评价页配置信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Appraise")]
                                [System.Text.Json.Serialization.JsonPropertyName("Appraise")]
                                public new DetailedPageInfo? OrderAppraisePageInfo { get; set; }

                                /// <summary>
                                /// 获取或设置订单详情页配置信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("OrderDetail")]
                                [System.Text.Json.Serialization.JsonPropertyName("OrderDetail")]
                                public new DetailedPageInfo? OrderDetailPageInfo { get; set; }
                            }

                            public class AftersaleOrderList : RestOrderCenterAppAddMainInfoRequest.Types.Order.Types.ExtendedInfo.Types.AftersaleOrderList
                            {
                                /// <summary>
                                /// 获取或设置售后单列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Items")]
                                [System.Text.Json.Serialization.JsonPropertyName("Items")]
                                public new IList<Types.AftersaleOrderItem> Items { get; set; } = new List<Types.AftersaleOrderItem>();
                            }

                            public class AftersaleOrderItem : RestOrderCenterAppAddMainInfoRequest.Types.Order.Types.ExtendedInfo.Types.AftersaleOrderItem
                            {
                                public static new class Types
                                {
                                    public class Refund : RestOrderCenterAppAddMainInfoRequest.Types.Order.Types.ExtendedInfo.Types.AftersaleOrderItem.Types.Refund
                                    {
                                        public static new class Types
                                        {
                                            public class Product : RestOrderCenterAppAddMainInfoRequest.Types.Order.Types.ExtendedInfo.Types.AftersaleOrderItem.Types.Refund.Types.Product
                                            {
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置退款或退货商品列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("Product")]
                                        [System.Text.Json.Serialization.JsonPropertyName("Product")]
                                        public new IList<Types.Product>? ProductList { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置退款信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Refund")]
                                [System.Text.Json.Serialization.JsonPropertyName("Refund")]
                                public new Types.Refund Refund { get; set; } = new Types.Refund();

                                /// <summary>
                                /// 获取或设置售后单详情页配置信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("OrderDetail")]
                                [System.Text.Json.Serialization.JsonPropertyName("OrderDetail")]
                                public new DetailedPageInfo? AftersaleOrderDetailPageInfo { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置订单信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("MainOrder")]
                        [System.Text.Json.Serialization.JsonPropertyName("MainOrder")]
                        public new Types.Order Order { get; set; } = new Types.Order();

                        /// <summary>
                        /// 获取或设置售后单列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("SubsOrder")]
                        [System.Text.Json.Serialization.JsonPropertyName("SubsOrder")]
                        public new Types.AftersaleOrderList? AftersaleOrderList { get; set; }
                    }

                    public class DetailedPageInfo : RestOrderCenterAppAddMainInfoRequest.Types.Order.Types.DetailedPageInfo
                    {
                    }
                }

                /// <summary>
                /// 获取或设置拓展信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("EXT")]
                [System.Text.Json.Serialization.JsonPropertyName("EXT")]
                public new Types.ExtendedInfo ExtendedInfo { get; set; } = new Types.ExtendedInfo();
            }
        }

        /// <summary>
        /// 获取或设置支付服务 AppKey。如果不指定将使用构造 <see cref="BaiduSmartAppOpenApiClient"/> 时的 <see cref="BaiduSmartAppOpenApiClientOptions.PaymentServiceAppKey"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? PaymentServiceAppKey { get; set; }

        /// <summary>
        /// 获取或设置用户 OpenId。与字段 <see cref="SwanId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置未登录用户标识。与字段 <see cref="OpenId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? SwanId { get; set; }

        /// <summary>
        /// 获取或设置场景 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SceneId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置场景类型。
        /// <para>默认值：2</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int SceneType { get; set; } = 2;

        /// <summary>
        /// 获取或设置宿主标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? HostName { get; set; }

        /// <summary>
        /// 获取或设置订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Data")]
        [System.Text.Json.Serialization.JsonPropertyName("Data")]
        public IList<Types.Order> OrderList { get; set; } = new List<Types.Order>();
    }
}
