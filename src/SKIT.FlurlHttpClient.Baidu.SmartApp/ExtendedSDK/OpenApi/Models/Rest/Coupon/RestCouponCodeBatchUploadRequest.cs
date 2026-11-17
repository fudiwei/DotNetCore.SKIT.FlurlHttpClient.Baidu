namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/v1.0/coupon/code/batchUpload 接口的请求。</para>
    /// </summary>
    public class RestCouponCodeBatchUploadRequest : BaiduSmartAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置卡券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("couponId")]
        [System.Text.Json.Serialization.JsonPropertyName("couponId")]
        public string? CouponId { get; set; }

        /// <summary>
        /// 获取或设置券码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("couponCodes")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedStringListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("couponCodes")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedStringListWithCommaSplitConverter))]
        public List<string>? CouponCodeList { get; set; }
    }
}
