namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/riskDetection/misjudgeFeedback 接口的请求。</para>
    /// </summary>
    public class RestRiskDetectionMisjudgeFeedbackRequest : BaiduSmartAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置检测 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("retrieveId")]
        [System.Text.Json.Serialization.JsonPropertyName("retrieveId")]
        public string RetrieveId { get; set; } = string.Empty;
    }
}
