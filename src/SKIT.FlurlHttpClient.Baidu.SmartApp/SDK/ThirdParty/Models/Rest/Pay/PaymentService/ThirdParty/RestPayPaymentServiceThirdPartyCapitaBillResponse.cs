namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/pay/paymentservice/tp/capitaBill 接口的响应。</para>
    /// </summary>
    public class RestPayPaymentServiceThirdPartyCapitaBillResponse : BaiduSmartAppThirdPartyResponse<RestPayPaymentServiceThirdPartyCapitaBillResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Bill : RestPayPaymentServiceThirdPartyOrderBillResponse.Types.Data.Types.Bill
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
    }
}
