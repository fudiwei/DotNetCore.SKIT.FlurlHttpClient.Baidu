namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/pay/paymentservice/capitaBill 接口的响应。</para>
    /// </summary>
    public class RestPayPaymentServiceCapitaBillResponse : BaiduSmartAppOpenApiResponse<RestPayPaymentServiceCapitaBillResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Bill : RestPayPaymentServiceOrderBillResponse.Types.Data.Types.Bill
                    {
                    }
                }

                /// <summary>
                /// 获取或设置资金账单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data")]
                [System.Text.Json.Serialization.JsonPropertyName("data")]
                public Types.Bill[] BillList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("totalCount")]
                [System.Text.Json.Serialization.JsonPropertyName("totalCount")]
                public int TotalCount { get; set; }
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
