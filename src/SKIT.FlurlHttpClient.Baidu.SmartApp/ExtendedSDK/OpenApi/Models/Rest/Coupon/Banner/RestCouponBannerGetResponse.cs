namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/v1.0/coupon/banner/get 接口的响应。</para>
    /// </summary>
    public class RestCouponBannerGetResponse : BaiduSmartAppOpenApiResponse<RestCouponBannerGetResponse.Types.Banner[]>
    {
        public static class Types
        {
            public class Banner
            {
                /// <summary>
                /// 获取或设置卡券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("couponId")]
                [System.Text.Json.Serialization.JsonPropertyName("couponId")]
                public string CouponId { get; set; } = default!;

                /// <summary>
                /// 获取或设置 Banner ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bannerId")]
                [System.Text.Json.Serialization.JsonPropertyName("bannerId")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long BannerId { get; set; }

                /// <summary>
                /// 获取或设置图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("picUrl")]
                [System.Text.Json.Serialization.JsonPropertyName("picUrl")]
                public string PictureUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置跳转页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appRedirectPath")]
                [System.Text.Json.Serialization.JsonPropertyName("appRedirectPath")]
                public string? RedirectPagePath { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("createTime")]
                [System.Text.Json.Serialization.JsonPropertyName("createTime")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("updateTime")]
                [System.Text.Json.Serialization.JsonPropertyName("updateTime")]
                public long UpdateTimestamp { get; set; }
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
