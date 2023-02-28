namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/pay/paymentservice/tp/orderBill 接口的响应。</para>
    /// </summary>
    public class RestPayPaymentServiceThirdPartyOrderBillResponse : BaiduSmartAppThirdPartyResponse<RestPayPaymentServiceThirdPartyOrderBillResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Bill
                    {
                        /// <summary>
                        /// 获取或设置账单名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("downloadName")]
                        [System.Text.Json.Serialization.JsonPropertyName("downloadName")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置导出状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("exportStatus")]
                        [System.Text.Json.Serialization.JsonPropertyName("exportStatus")]
                        public int ExportStatus { get; set; }

                        /// <summary>
                        /// 获取或设置下载地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string Url { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置对账单列表。
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
