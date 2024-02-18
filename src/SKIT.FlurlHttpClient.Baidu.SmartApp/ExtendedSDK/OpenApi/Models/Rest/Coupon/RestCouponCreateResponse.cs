namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/v1.0/coupon/create 接口的响应。</para>
    /// </summary>
    public class RestCouponCreateResponse : BaiduSmartAppOpenApiResponse<RestCouponCreateResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置卡券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("couponId")]
                [System.Text.Json.Serialization.JsonPropertyName("couponId")]
                public string CouponId { get; set; } = default!;
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
