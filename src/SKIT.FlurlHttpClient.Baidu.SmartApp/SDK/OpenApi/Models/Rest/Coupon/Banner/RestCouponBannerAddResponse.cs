namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/v1.0/coupon/banner/add 接口的响应。</para>
    /// </summary>
    public class RestCouponBannerAddResponse : BaiduSmartAppOpenApiResponse<RestCouponBannerAddResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置 Banner ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bannerId")]
                [System.Text.Json.Serialization.JsonPropertyName("bannerId")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long BannerId { get; set; }
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
