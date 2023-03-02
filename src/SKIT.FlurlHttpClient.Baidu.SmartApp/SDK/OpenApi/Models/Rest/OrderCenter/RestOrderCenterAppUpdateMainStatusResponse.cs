namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/ordercenter/app/update/main/status 接口的响应。</para>
    /// </summary>
    public class RestOrderCenterAppUpdateMainStatusResponse : BaiduSmartAppOpenApiResponse<RestOrderCenterAppUpdateMainStatusResponse.Types.Result[]>
    {
        public static class Types
        {
            public class Result : RestOrderCenterAppAddMainInfoResponse.Types.Result
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
