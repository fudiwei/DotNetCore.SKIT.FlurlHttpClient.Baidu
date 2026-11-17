namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/ordercenter/app/update/main/info 接口的请求。</para>
    /// </summary>
    public class RestOrderCenterAppUpdateMainInfoRequest : BaiduSmartAppOpenApiRequest
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
                                    public class Product : RestOrderCenterAppAddMainInfoRequest.Types.Order.Types.ExtendedInfo.Types.Order.Types.__zz__Product
                                    {
                                        public static class Types
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
                                        public List<Types.SKUAttribute>? SKUAttributeList { get; set; }

                                        /// <summary>
                                        /// 获取或设置商品详情页配置信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("DetailPage")]
                                        [System.Text.Json.Serialization.JsonPropertyName("DetailPage")]
                                        public DetailedPageInfo? ProductDetailPageInfo { get; set; }
                                    }

                                    public class Payment : RestOrderCenterAppAddMainInfoRequest.Types.Order.Types.ExtendedInfo.Types.Order.Types.__zz__Payment
                                    {
                                        public static class Types
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
                                        public List<Types.Item>? PreferentialList { get; set; }

                                        /// <summary>
                                        /// 获取或设置付款信息列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("PaymentInfo")]
                                        [System.Text.Json.Serialization.JsonPropertyName("PaymentInfo")]
                                        public List<Types.Item>? PaymentList { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置商品列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Products")]
                                [System.Text.Json.Serialization.JsonPropertyName("Products")]
                                public List<Types.Product>? ProductList { get; set; }

                                /// <summary>
                                /// 获取或设置支付信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Payment")]
                                [System.Text.Json.Serialization.JsonPropertyName("Payment")]
                                public Types.Payment? Payment { get; set; }

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
                        }

                        /// <summary>
                        /// 获取或设置订单信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("MainOrder")]
                        [System.Text.Json.Serialization.JsonPropertyName("MainOrder")]
                        public Types.Order? Order { get; set; }
                    }

                    public class DetailedPageInfo : RestOrderCenterAppAddMainInfoRequest.Types.Order.Types.DetailedPageInfo
                    {
                    }
                }

                /// <summary>
                /// 获取或设置小程序 AppKey。如果不指定将使用构造 <see cref="BaiduSmartAppOpenApiClient"/> 时的 <see cref="BaiduSmartAppOpenApiClientOptions.AppKey"/> 参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("BizAPPID")]
                [System.Text.Json.Serialization.JsonPropertyName("BizAPPID")]
                public string? AppKey { get; set; }

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
                public string? OutOrderId { get; set; }

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
                public Types.ExtendedInfo? ExtendedInfo { get; set; }
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
        public string? SceneId { get; set; }

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
        public List<Types.Order>? OrderList { get; set; }
    }
}
