namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/v1.0/coupon/batchGet 接口的响应。</para>
    /// </summary>
    public class RestCouponBatchGetResponse : BaiduSmartAppOpenApiResponse<RestCouponBatchGetResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Coupon
                    {
                        public static class Types
                        {
                            public class BaseInfo : RestCouponCreateRequest.Types.__zz__BaseInfo
                            {
                                public static class Types
                                {
                                    public class DateInfo : RestCouponCreateRequest.Types.BaseInfo.Types.DateInfo
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置有效期信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("dateInfo")]
                                [System.Text.Json.Serialization.JsonPropertyName("dateInfo")]
                                public Types.DateInfo? DateInfo { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置卡券 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("couponId")]
                        [System.Text.Json.Serialization.JsonPropertyName("couponId")]
                        public string? CouponId { get; set; }

                        /// <summary>
                        /// 获取或设置卡券类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("couponType")]
                        [System.Text.Json.Serialization.JsonPropertyName("couponType")]
                        public string? CouponType { get; set; }

                        /// <summary>
                        /// 获取或设置折扣比例（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount")]
                        public int? Discount { get; set; }

                        /// <summary>
                        /// 获取或设置卡券基础信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("baseInfo")]
                        [System.Text.Json.Serialization.JsonPropertyName("baseInfo")]
                        public Types.BaseInfo? BaseInfo { get; set; }

                        /// <summary>
                        /// 获取或设置卡券描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("description")]
                        [System.Text.Json.Serialization.JsonPropertyName("description")]
                        public string? Description { get; set; }

                        /// <summary>
                        /// 获取或设置卡券领取事件回调 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("callbackUrl")]
                        [System.Text.Json.Serialization.JsonPropertyName("callbackUrl")]
                        public string? CallbackUrl { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置卡券列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dataList")]
                [System.Text.Json.Serialization.JsonPropertyName("dataList")]
                public List<Types.Coupon>? CouponList { get; set; }

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

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public override string? ErrorMessage { get; set; }
    }
}
