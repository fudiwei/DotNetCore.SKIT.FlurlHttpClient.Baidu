namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/ordercenter/app/update/sub/status 接口的响应。</para>
    /// </summary>
    public class RestOrderCenterAppUpdateSubStatusResponse : BaiduSmartAppOpenApiResponse<RestOrderCenterAppUpdateSubStatusResponse.Types.Result[]>
    {
        public static class Types
        {
            public class Result : RestOrderCenterAppAppendSubInfoResponse.Types.Result
            {
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
