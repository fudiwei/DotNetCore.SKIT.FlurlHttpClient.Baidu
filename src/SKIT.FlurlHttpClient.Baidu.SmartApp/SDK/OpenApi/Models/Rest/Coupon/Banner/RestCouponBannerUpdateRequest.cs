namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/v1.0/coupon/banner/update 接口的请求。</para>
    /// </summary>
    public class RestCouponBannerUpdateRequest : BaiduSmartAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置卡券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("couponId")]
        [System.Text.Json.Serialization.JsonPropertyName("couponId")]
        public string CouponId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置 Banner ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bannerId")]
        [System.Text.Json.Serialization.JsonPropertyName("bannerId")]
        public long BannerId { get; set; }

        /// <summary>
        /// 获取或设置图片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("picUrl")]
        [System.Text.Json.Serialization.JsonPropertyName("picUrl")]
        public string PictureUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置跳转页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appRedirectPath")]
        [System.Text.Json.Serialization.JsonPropertyName("appRedirectPath")]
        public string? RedirectPagePath { get; set; }
    }
}
