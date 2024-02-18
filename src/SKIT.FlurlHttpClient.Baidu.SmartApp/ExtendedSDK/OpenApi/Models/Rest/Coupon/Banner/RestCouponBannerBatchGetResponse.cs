namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/v1.0/coupon/banner/batchGet 接口的响应。</para>
    /// </summary>
    public class RestCouponBannerBatchGetResponse : BaiduSmartAppOpenApiResponse<RestCouponBannerBatchGetResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Banner : RestCouponBannerGetResponse.Types.Banner
                    {
                    }
                }

                /// <summary>
                /// 获取或设置 Banner 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dataList")]
                [System.Text.Json.Serialization.JsonPropertyName("dataList")]
                public Types.Banner[] BannerList { get; set; } = default!;

                /// <summary>
                /// 获取或设置当前分页页数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pageNo")]
                [System.Text.Json.Serialization.JsonPropertyName("pageNo")]
                public int PageNumber { get; set; }

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
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
