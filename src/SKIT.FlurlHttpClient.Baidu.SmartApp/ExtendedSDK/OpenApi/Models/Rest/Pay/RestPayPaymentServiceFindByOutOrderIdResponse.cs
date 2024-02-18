namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/pay/paymentservice/findByTpOrderId 接口的响应。</para>
    /// </summary>
    public class RestPayPaymentServiceFindByOutOrderIdResponse : BaiduSmartAppOpenApiResponse<RestPayPaymentServiceFindByOutOrderIdResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appId")]
                [System.Text.Json.Serialization.JsonPropertyName("appId")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序 AppKey。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appKey")]
                [System.Text.Json.Serialization.JsonPropertyName("appKey")]
                public string AppKey { get; set; } = default!;

                /// <summary>
                /// 获取或设置第三方平台 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tpId")]
                [System.Text.Json.Serialization.JsonPropertyName("tpId")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string ThirdPartyAppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置开发者自定义订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tpOrderId")]
                [System.Text.Json.Serialization.JsonPropertyName("tpOrderId")]
                public string OutOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("orderId")]
                [System.Text.Json.Serialization.JsonPropertyName("orderId")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long OrderId { get; set; }

                /// <summary>
                /// 获取或设置订单类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int OrderType { get; set; }

                /// <summary>
                /// 获取或设置父订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parentOrderId")]
                [System.Text.Json.Serialization.JsonPropertyName("parentOrderId")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long? ParentOrderId { get; set; }

                /// <summary>
                /// 获取或设置父订单类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parentType")]
                [System.Text.Json.Serialization.JsonPropertyName("parentType")]
                public int? ParentOrderType { get; set; }

                /// <summary>
                /// 获取或设置支付单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tradeNo")]
                [System.Text.Json.Serialization.JsonPropertyName("tradeNo")]
                public string? TradeNumber { get; set; }

                /// <summary>
                /// 获取或设置百度收银台的财务结算凭证。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dealId")]
                [System.Text.Json.Serialization.JsonPropertyName("dealId")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string? DealId { get; set; }

                /// <summary>
                /// 获取或设置业务扩展字段。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bizInfo")]
                [System.Text.Json.Serialization.JsonPropertyName("bizInfo")]
                public string? BusinessInfo { get; set; }

                /// <summary>
                /// 获取或设置用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openId")]
                [System.Text.Json.Serialization.JsonPropertyName("openId")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置百度收银台用户 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userId")]
                [System.Text.Json.Serialization.JsonPropertyName("userId")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long UserId { get; set; }

                /// <summary>
                /// 获取或设置数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count")]
                [System.Text.Json.Serialization.JsonPropertyName("count")]
                public int Count { get; set; }

                /// <summary>
                /// 获取或设置原价金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("oriPrice")]
                [System.Text.Json.Serialization.JsonPropertyName("oriPrice")]
                public int OriginalAmount { get; set; }

                /// <summary>
                /// 获取或设置支付金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payMoney")]
                [System.Text.Json.Serialization.JsonPropertyName("payMoney")]
                public int PayAmount { get; set; }

                /// <summary>
                /// 获取或设置结算金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settlePrice")]
                [System.Text.Json.Serialization.JsonPropertyName("settlePrice")]
                public int SettleAmount { get; set; }

                /// <summary>
                /// 获取或设置订单金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("totalMoney")]
                [System.Text.Json.Serialization.JsonPropertyName("totalMoney")]
                public int TotalAmount { get; set; }

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置订单子状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subStatus")]
                [System.Text.Json.Serialization.JsonPropertyName("subStatus")]
                public int SubStatus { get; set; }

                /// <summary>
                /// 获取或设置下单时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("createTime")]
                [System.Text.Json.Serialization.JsonPropertyName("createTime")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public override string? ErrorMessage { get; set; }
    }
}
