using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/ordercenter/update/main/status 接口的请求。</para>
    /// </summary>
    public class RestOrderCenterUpdateMainStatusRequest : BaiduSmartAppThirdPartyRequest
    {
        public static class Types
        {
            public class Order
            {
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
