namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Events
{
    /// <summary>
    /// <para>表示 EVENT.user_get_coupon 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://smartprogram.baidu.com/docs/develop/api/open/coupons_collect/ ]]>
    /// </para>
    /// </summary>
    public class UserGetCouponEvent : BaiduSmartAppOpenApiEvent
    {
        /// <summary>
        /// 获取或设置卡券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CouponId")]
        [System.Text.Json.Serialization.JsonPropertyName("CouponId")]
        [System.Xml.Serialization.XmlElement("CouponId")]
        public string CouponId { get; set; } = default!;

        /// <summary>
        /// 获取或设置卡券券码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("UserCouponCode")]
        [System.Text.Json.Serialization.JsonPropertyName("UserCouponCode")]
        [System.Xml.Serialization.XmlElement("UserCouponCode")]
        public string CouponCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置卡券领取唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CouponTakeId")]
        [System.Text.Json.Serialization.JsonPropertyName("CouponTakeId")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
        [System.Xml.Serialization.XmlElement("CouponTakeId", IsNullable = true)]
        public string? UniqueTakingId { get; set; }
    }
}
