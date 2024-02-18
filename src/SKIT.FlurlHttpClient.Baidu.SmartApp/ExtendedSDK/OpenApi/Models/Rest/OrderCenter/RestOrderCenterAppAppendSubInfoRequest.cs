using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/ordercenter/app/append/sub/info 接口的请求。</para>
    /// </summary>
    public class RestOrderCenterAppAppendSubInfoRequest : BaiduSmartAppOpenApiRequest
    {
        public static class Types
        {
            public class Order
            {
                public static class Types
                {
                    public class ExtendedInfo : RestOrderCenterAppAddMainInfoRequest.Types.Order.Types.ExtendedInfo
                    {
                        public static new class Types
                        {
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
