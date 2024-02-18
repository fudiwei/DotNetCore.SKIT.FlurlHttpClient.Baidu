namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/riskDetection/v2/syncCheckText 接口的响应。</para>
    /// </summary>
    public class RestRiskDetectionSyncCheckTextV2Response : BaiduSmartAppOpenApiResponse<RestRiskDetectionSyncCheckTextV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Result
                    {
                        /// <summary>
                        /// 获取或设置检测类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置错误代码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("errno")]
                        [System.Text.Json.Serialization.JsonPropertyName("errno")]
                        public int ErrorNumber { get; set; }

                        /// <summary>
                        /// 获取或设置错误信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("msg")]
                        [System.Text.Json.Serialization.JsonPropertyName("msg")]
                        public string? ErrorMessage { get; set; }
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
