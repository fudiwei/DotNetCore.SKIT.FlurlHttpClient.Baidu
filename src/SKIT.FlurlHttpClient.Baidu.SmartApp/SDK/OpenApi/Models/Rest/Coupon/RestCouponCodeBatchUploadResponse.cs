namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/v1.0/coupon/code/batchUpload 接口的响应。</para>
    /// </summary>
    public class RestCouponCodeBatchUploadResponse : BaiduSmartAppOpenApiResponse<RestCouponCodeBatchUploadResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置成功条数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("successNum")]
                [System.Text.Json.Serialization.JsonPropertyName("successNum")]
                public int SuccessCount { get; set; }

                /// <summary>
                /// 获取或设置失败条数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failNum")]
                [System.Text.Json.Serialization.JsonPropertyName("failNum")]
                public int FailCount { get; set; }
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
