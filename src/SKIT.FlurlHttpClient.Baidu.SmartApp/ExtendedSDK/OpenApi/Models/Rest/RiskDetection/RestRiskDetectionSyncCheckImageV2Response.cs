namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/riskDetection/v2/syncCheckImage 接口的响应。</para>
    /// </summary>
    public class RestRiskDetectionSyncCheckImageV2Response : BaiduSmartAppOpenApiResponse<RestRiskDetectionSyncCheckImageV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Result : RestRiskDetectionSyncCheckTextV2Response.Types.Data.Types.Result
                    {
                    }
                }

                /// <summary>
                /// 获取或设置检测 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("retrieveId")]
                [System.Text.Json.Serialization.JsonPropertyName("retrieveId")]
                public string RetrieveId { get; set; } = default!;

                /// <summary>
                /// 获取或设置检测结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("res")]
                [System.Text.Json.Serialization.JsonPropertyName("res")]
                public Types.Result[] ResultList { get; set; } = default!;
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
