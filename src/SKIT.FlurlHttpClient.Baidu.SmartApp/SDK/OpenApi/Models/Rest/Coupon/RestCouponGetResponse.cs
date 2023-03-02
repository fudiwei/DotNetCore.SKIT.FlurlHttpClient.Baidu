namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/v1.0/coupon/get 接口的响应。</para>
    /// </summary>
    public class RestCouponGetResponse : BaiduSmartAppOpenApiResponse<RestCouponGetResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class BaseInfo
                    {
                        public static class Types
                        {
                            public class DateInfo : RestCouponCreateRequest.Types.BaseInfo.Types.DateInfo
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置背景色。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("color")]
                        [System.Text.Json.Serialization.JsonPropertyName("color")]
                        public string Color { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置券码类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("codeType")]
                        [System.Text.Json.Serialization.JsonPropertyName("codeType")]
                        public int CodeType { get; set; }

                        /// <summary>
                        /// 获取或设置有效期信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("dateInfo")]
                        [System.Text.Json.Serialization.JsonPropertyName("dateInfo")]
                        public Types.DateInfo DateInfo { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置库存数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("quantity")]
                        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                        public int Quantity { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置每人领取次数限制。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("getLimit")]
                        [System.Text.Json.Serialization.JsonPropertyName("getLimit")]
                        public int LimitCount { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appRedirectPath")]
                        [System.Text.Json.Serialization.JsonPropertyName("appRedirectPath")]
                        public string? RedirectPagePath { get; set; }

                        /// <summary>
                        /// 获取或设置是否是百度会员券。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("isMemberShip")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("isMemberShip")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool IsMembership { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置卡券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("couponId")]
                [System.Text.Json.Serialization.JsonPropertyName("couponId")]
                public string CouponId { get; set; } = default!;

                /// <summary>
                /// 获取或设置卡券类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("couponType")]
                [System.Text.Json.Serialization.JsonPropertyName("couponType")]
                public string CouponType { get; set; } = default!;

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
                public Types.BaseInfo BaseInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置卡券描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置卡券领取事件回调 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("callbackUrl")]
                [System.Text.Json.Serialization.JsonPropertyName("callbackUrl")]
                public string CallbackUrl { get; set; } = default!;
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
