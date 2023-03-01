using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/ordercenter/update/sub/status 接口的请求。</para>
    /// </summary>
    public class RestOrderCenterUpdateSubStatusRequest : BaiduSmartAppThirdPartyRequest
    {
        public static class Types
        {
            public class Order : RestOrderCenterAppendSubInfoRequest.Types.Order
            {
                public static new class Types
                {
                    public class ExtendedInfo : RestOrderCenterAppendSubInfoRequest.Types.Order.Types.ExtendedInfo
                    {
                        public static new class Types
                        {
                            public class AftersaleOrderList : RestOrderCenterAppendSubInfoRequest.Types.Order.Types.ExtendedInfo.Types.AftersaleOrderList
                            {
                                /// <summary>
                                /// 获取或设置售后单列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Items")]
                                [System.Text.Json.Serialization.JsonPropertyName("Items")]
                                public new IList<Types.AftersaleOrderItem> Items { get; set; } = new List<Types.AftersaleOrderItem>();
                            }

                            public class AftersaleOrderItem
                            {
                                /// <summary>
                                /// 获取或设置开发者自定义售后单 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("SubOrderID")]
                                [System.Text.Json.Serialization.JsonPropertyName("SubOrderID")]
                                public string OutAftersaleOrderId { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置售后单状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("SubStatus")]
                                [System.Text.Json.Serialization.JsonPropertyName("SubStatus")]
                                public int Status { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置售后单列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("SubsOrder")]
                        [System.Text.Json.Serialization.JsonPropertyName("SubsOrder")]
                        public new Types.AftersaleOrderList? AftersaleOrderList { get; set; }
                    }

                    public class DetailedPageInfo : RestOrderCenterAppendSubInfoRequest.Types.Order.Types.DetailedPageInfo
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
        /// 获取或设置支付服务 AppKey。如果不指定将使用构造 <see cref="BaiduSmartAppThirdPartyClient"/> 时的 <see cref="BaiduSmartAppThirdPartyClientOptions.PaymentServiceAppKey"/> 参数.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pmAppKey")]
        [System.Text.Json.Serialization.JsonPropertyName("pmAppKey")]
        public string? ServiceAppKey { get; set; }

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置场景 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_id")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_id")]
        public string SceneId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置场景类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_type")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_type")]
        public int SceneType { get; set; }

        /// <summary>
        /// 获取或设置订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Data")]
        [System.Text.Json.Serialization.JsonPropertyName("Data")]
        public IList<Types.Order> OrderList { get; set; } = new List<Types.Order>();

        /// <summary>
        /// 获取或设置宿主标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hostname")]
        [System.Text.Json.Serialization.JsonPropertyName("hostname")]
        public string? HostName { get; set; }
    }
}
