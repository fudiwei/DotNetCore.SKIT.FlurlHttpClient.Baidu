using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/ordercenter/app/add/main/info 接口的请求。</para>
    /// </summary>
    public class RestOrderCenterAppAddMainInfoRequest : BaiduSmartAppOpenApiRequest
    {
        public static class Types
        {
            public class Order
            {
                public static class Types
                {
                    public class ExtendedInfo
                    {
                        public static class Types
                        {
                            public class Order
                            {
                                public static class Types
                                {
                                    public class Product
                                    {
                                        public static class Types
                                        {
                                            public class SKUAttribute
                                            {
                                                /// <summary>
                                                /// 获取或设置属性名称。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("Name")]
                                                [System.Text.Json.Serialization.JsonPropertyName("Name")]
                                                public string Name { get; set; } = string.Empty;

                                                /// <summary>
                                                /// 获取或设置属性值。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("Value")]
                                                [System.Text.Json.Serialization.JsonPropertyName("Value")]
                                                public string Value { get; set; } = string.Empty;
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置开发者自定义商品 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ID")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ID")]
                                        public string OutProductId { get; set; } = string.Empty;

                                        /// <summary>
                                        /// 获取或设置商品名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("Name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("Name")]
                                        public string Name { get; set; } = string.Empty;

                                        /// <summary>
                                        /// 获取或设置商品描述。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("Desc")]
                                        [System.Text.Json.Serialization.JsonPropertyName("Desc")]
                                        public string? Description { get; set; }

                                        /// <summary>
                                        /// 获取或设置扩展字段。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ExtInfo")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ExtInfo")]
                                        public string? Extra { get; set; }

                                        /// <summary>
                                        /// 获取或设置商品原价（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("Price")]
                                        [System.Text.Json.Serialization.JsonPropertyName("Price")]
                                        public int Price { get; set; }

                                        /// <summary>
                                        /// 获取或设置实付价格（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("PayPrice")]
                                        [System.Text.Json.Serialization.JsonPropertyName("PayPrice")]
                                        public int PayPrice { get; set; }

                                        /// <summary>
                                        /// 获取或设置数量。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("Quantity")]
                                        [System.Text.Json.Serialization.JsonPropertyName("Quantity")]
                                        public int Quantity { get; set; }

                                        /// <summary>
                                        /// 获取或设置商品图片 URL 列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ImgList")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ImgList")]
                                        public IList<string>? ImageUrlList { get; set; }

                                        /// <summary>
                                        /// 获取或设置商品 SKU 属性列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("SkuAttr")]
                                        [System.Text.Json.Serialization.JsonPropertyName("SkuAttr")]
                                        public IList<Types.SKUAttribute>? SKUAttributeList { get; set; }

                                        /// <summary>
                                        /// 获取或设置商品详情页配置信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("DetailPage")]
                                        [System.Text.Json.Serialization.JsonPropertyName("DetailPage")]
                                        public DetailedPageInfo? ProductDetailPageInfo { get; set; }
                                    }

                                    public class Payment
                                    {
                                        public static class Types
                                        {
                                            public class Item
                                            {
                                                /// <summary>
                                                /// 获取或设置项目名称。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("Name")]
                                                [System.Text.Json.Serialization.JsonPropertyName("Name")]
                                                public string? Name { get; set; }

                                                /// <summary>
                                                /// 获取或设置金额（单位：分）。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("Value")]
                                                [System.Text.Json.Serialization.JsonPropertyName("Value")]
                                                public int Value { get; set; }

                                                /// <summary>
                                                /// 获取或设置数量。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("Quantity")]
                                                [System.Text.Json.Serialization.JsonPropertyName("Quantity")]
                                                public int Quantity { get; set; }
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置付款方式。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("Method")]
                                        [System.Text.Json.Serialization.JsonPropertyName("Method")]
                                        public int PayMethod { get; set; }

                                        /// <summary>
                                        /// 获取或设置付款金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("Amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("Amount")]
                                        public int PayAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置是否付款。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("IsPayment")]
                                        [System.Text.Json.Serialization.JsonPropertyName("IsPayment")]
                                        public bool IsPaid { get; set; }

                                        /// <summary>
                                        /// 获取或设置付款时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("Time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("Time")]
                                        public long? PayTimestamp { get; set; }

                                        /// <summary>
                                        /// 获取或设置优惠信息列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("PreferentialInfo")]
                                        [System.Text.Json.Serialization.JsonPropertyName("PreferentialInfo")]
                                        public IList<Types.Item>? PreferentialList { get; set; }

                                        /// <summary>
                                        /// 获取或设置付款信息列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("PaymentInfo")]
                                        [System.Text.Json.Serialization.JsonPropertyName("PaymentInfo")]
                                        public IList<Types.Item>? PaymentList { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置商品列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Products")]
                                [System.Text.Json.Serialization.JsonPropertyName("Products")]
                                public IList<Types.Product> ProductList { get; set; } = new List<Types.Product>();

                                /// <summary>
                                /// 获取或设置支付信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Payment")]
                                [System.Text.Json.Serialization.JsonPropertyName("Payment")]
                                public Types.Payment Payment { get; set; } = new Types.Payment();

                                /// <summary>
                                /// 获取或设置订单评价页配置信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Appraise")]
                                [System.Text.Json.Serialization.JsonPropertyName("Appraise")]
                                public DetailedPageInfo? OrderAppraisePageInfo { get; set; }

                                /// <summary>
                                /// 获取或设置订单详情页配置信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("OrderDetail")]
                                [System.Text.Json.Serialization.JsonPropertyName("OrderDetail")]
                                public DetailedPageInfo? OrderDetailPageInfo { get; set; }
                            }

                            public class AftersaleOrderList
                            {
                                /// <summary>
                                /// 获取或设置售后单状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Status")]
                                [System.Text.Json.Serialization.JsonPropertyName("Status")]
                                public int Status { get; set; }

                                /// <summary>
                                /// 获取或设置售后单列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Items")]
                                [System.Text.Json.Serialization.JsonPropertyName("Items")]
                                public IList<Types.AftersaleOrderItem> Items { get; set; } = new List<Types.AftersaleOrderItem>();
                            }

                            public class AftersaleOrderItem
                            {
                                public static class Types
                                {
                                    public class Refund
                                    {
                                        public static class Types
                                        {
                                            public class Product
                                            {
                                                /// <summary>
                                                /// 获取或设置开发者自定义商品 ID。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("ID")]
                                                [System.Text.Json.Serialization.JsonPropertyName("ID")]
                                                public string OutProductId { get; set; } = string.Empty;

                                                /// <summary>
                                                /// 获取或设置退款或退货数量（单位：分）。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("Quantity")]
                                                [System.Text.Json.Serialization.JsonPropertyName("Quantity")]
                                                public int Quantity { get; set; }

                                                /// <summary>
                                                /// 获取或设置退款或退货金额（单位：分）。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("Amount")]
                                                [System.Text.Json.Serialization.JsonPropertyName("Amount")]
                                                public int Amount { get; set; }
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置退款金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("Amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("Amount")]
                                        public int Amount { get; set; }

                                        /// <summary>
                                        /// 获取或设置退款或退货商品列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("Product")]
                                        [System.Text.Json.Serialization.JsonPropertyName("Product")]
                                        public IList<Types.Product>? ProductList { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置开发者自定义售后单 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("SubOrderID")]
                                [System.Text.Json.Serialization.JsonPropertyName("SubOrderID")]
                                public string OutAftersaleOrderId { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("OrderType")]
                                [System.Text.Json.Serialization.JsonPropertyName("OrderType")]
                                public int Type { get; set; }

                                /// <summary>
                                /// 获取或设置售后单状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("SubStatus")]
                                [System.Text.Json.Serialization.JsonPropertyName("SubStatus")]
                                public int Status { get; set; }

                                /// <summary>
                                /// 获取或设置创建时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Ctime")]
                                [System.Text.Json.Serialization.JsonPropertyName("Ctime")]
                                public long CreateTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置最后修改时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Mtime")]
                                [System.Text.Json.Serialization.JsonPropertyName("Mtime")]
                                public long ModifyTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置退款信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Refund")]
                                [System.Text.Json.Serialization.JsonPropertyName("Refund")]
                                public Types.Refund Refund { get; set; } = new Types.Refund();

                                /// <summary>
                                /// 获取或设置售后单详情页配置信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("OrderDetail")]
                                [System.Text.Json.Serialization.JsonPropertyName("OrderDetail")]
                                public DetailedPageInfo? AftersaleOrderDetailPageInfo { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置订单信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("MainOrder")]
                        [System.Text.Json.Serialization.JsonPropertyName("MainOrder")]
                        public Types.Order Order { get; set; } = new Types.Order();

                        /// <summary>
                        /// 获取或设置售后单列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("SubsOrder")]
                        [System.Text.Json.Serialization.JsonPropertyName("SubsOrder")]
                        public Types.AftersaleOrderList? AftersaleOrderList { get; set; }
                    }

                    public class DetailedPageInfo
                    {
                        /// <summary>
                        /// 获取或设置页面名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Name")]
                        [System.Text.Json.Serialization.JsonPropertyName("Name")]
                        public string? Name { get; set; }

                        /// <summary>
                        /// 获取或设置状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Status")]
                        [System.Text.Json.Serialization.JsonPropertyName("Status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置小程序 Scheme。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("SwanSchema")]
                        [System.Text.Json.Serialization.JsonPropertyName("SwanSchema")]
                        public string? SwanSchema { get; set; }

                        /// <summary>
                        /// 获取或设置 iOS Scheme。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("IPhoneSchema")]
                        [System.Text.Json.Serialization.JsonPropertyName("IPhoneSchema")]
                        public string? iOSSchema { get; set; }

                        /// <summary>
                        /// 获取或设置 Android Scheme。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("AndroidSchema")]
                        [System.Text.Json.Serialization.JsonPropertyName("AndroidSchema")]
                        public string? AndroidSchema { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置小程序 AppKey。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("BizAPPID")]
                [System.Text.Json.Serialization.JsonPropertyName("BizAPPID")]
                public string AppKey { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置订单种类。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("CateID")]
                [System.Text.Json.Serialization.JsonPropertyName("CateID")]
                public int OrderCategory { get; set; }

                /// <summary>
                /// 获取或设置开发者自定义订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ResourceID")]
                [System.Text.Json.Serialization.JsonPropertyName("ResourceID")]
                public string OutOrderId { get; set; } = string.Empty;
                
                /// <summary>
                /// 获取或设置订单标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Title")]
                [System.Text.Json.Serialization.JsonPropertyName("Title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Ctime")]
                [System.Text.Json.Serialization.JsonPropertyName("Ctime")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置最后修改时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Mtime")]
                [System.Text.Json.Serialization.JsonPropertyName("Mtime")]
                public long ModifyTimestamp { get; set; }

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Status")]
                [System.Text.Json.Serialization.JsonPropertyName("Status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置拓展信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("EXT")]
                [System.Text.Json.Serialization.JsonPropertyName("EXT")]
                public Types.ExtendedInfo ExtendedInfo { get; set; } = new Types.ExtendedInfo();
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
