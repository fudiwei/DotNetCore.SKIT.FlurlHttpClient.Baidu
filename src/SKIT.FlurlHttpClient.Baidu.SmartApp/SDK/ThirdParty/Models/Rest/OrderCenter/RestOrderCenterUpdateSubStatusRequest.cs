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
        /// 获取或设置订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Data")]
        [System.Text.Json.Serialization.JsonPropertyName("Data")]
        public IList<Types.Order> OrderList { get; set; } = new List<Types.Order>();
    }
}
