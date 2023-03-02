namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/v1.0/coupon/banner/delete 接口的请求。</para>
    /// </summary>
    public class RestCouponBannerDeleteRequest : BaiduSmartAppOpenApiRequest
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
    }
}
