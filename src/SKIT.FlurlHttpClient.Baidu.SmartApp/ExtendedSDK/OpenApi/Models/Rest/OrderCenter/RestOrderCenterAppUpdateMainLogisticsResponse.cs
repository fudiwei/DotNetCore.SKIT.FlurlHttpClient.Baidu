namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/ordercenter/app/update/main/logistics 接口的响应。</para>
    /// </summary>
    public class RestOrderCenterAppUpdateMainLogisticsResponse : BaiduSmartAppOpenApiResponse<List<RestOrderCenterAppUpdateMainLogisticsResponse.Types.Result>?>
    {
        public static class Types
        {
            public class Result : RestOrderCenterAppAddMainInfoResponse.Types.Result
            {
            }
        }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public override string? ErrorMessage { get; set; }
    }
}
