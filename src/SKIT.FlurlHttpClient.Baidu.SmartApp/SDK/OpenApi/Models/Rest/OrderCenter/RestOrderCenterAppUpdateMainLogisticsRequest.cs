using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/ordercenter/app/update/main/logistics 接口的请求。</para>
    /// </summary>
    public class RestOrderCenterAppUpdateMainLogisticsRequest : BaiduSmartAppOpenApiRequest
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
                                    public class Express
                                    {
                                        /// <summary>
                                        /// 获取或设置快递单号。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ID")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ID")]
                                        public string ExpressId { get; set; } = string.Empty;

                                        /// <summary>
                                        /// 获取或设置快递类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("Type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("Type")]
                                        public int Type { get; set; }

                                        /// <summary>
                                        /// 获取或设置快递公司编号。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("Code")]
                                        [System.Text.Json.Serialization.JsonPropertyName("Code")]
                                        public string CompanyCode { get; set; } = string.Empty;

                                        /// <summary>
                                        /// 获取或设置快递公司名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("Name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("Name")]
                                        public string? CompanyName { get; set; }

                                        /// <summary>
                                        /// 获取或设置快递状态。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("Status")]
                                        [System.Text.Json.Serialization.JsonPropertyName("Status")]
                                        public int Status { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置快递列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Express")]
                                [System.Text.Json.Serialization.JsonPropertyName("Express")]
                                public IList<Types.Express> ExpressList { get; set; } = new List<Types.Express>();
                            }
                        }

                        /// <summary>
                        /// 获取或设置订单信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("MainOrder")]
                        [System.Text.Json.Serialization.JsonPropertyName("MainOrder")]
                        public Types.Order Order { get; set; } = new Types.Order();
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
