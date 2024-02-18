namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/v1.0/coupon/send 接口的请求。</para>
    /// </summary>
    public class RestCouponSendRequest : BaiduSmartAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置卡券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("couponId")]
        [System.Text.Json.Serialization.JsonPropertyName("couponId")]
        public string CouponId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openId")]
        [System.Text.Json.Serialization.JsonPropertyName("openId")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置卡券下发唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uniqueSendingIdentity")]
        [System.Text.Json.Serialization.JsonPropertyName("uniqueSendingIdentity")]
        public string UniqueSendingId { get; set; } = string.Empty;
    }
}
