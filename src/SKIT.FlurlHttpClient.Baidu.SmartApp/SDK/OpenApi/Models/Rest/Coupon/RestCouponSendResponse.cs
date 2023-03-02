namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/v1.0/coupon/send 接口的响应。</para>
    /// </summary>
    public class RestCouponSendResponse : BaiduSmartAppOpenApiResponse<RestCouponSendResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置卡券领取唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("couponTakeId")]
                [System.Text.Json.Serialization.JsonPropertyName("couponTakeId")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                public string UniqueTakingId { get; set; } = default!;
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
