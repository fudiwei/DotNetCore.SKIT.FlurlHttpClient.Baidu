namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/v1.0/coupon/create 接口的请求。</para>
    /// </summary>
    public class RestCouponCreateRequest : BaiduSmartAppOpenApiRequest
    {
        public static class Types
        {
            public class BaseInfo
            {
                public static class Types
                {
                    public class DateInfo
                    {
                        /// <summary>
                        /// 获取或设置使用时间类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置使用开始时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("beginTimestamp")]
                        [System.Text.Json.Serialization.JsonPropertyName("beginTimestamp")]
                        public long? BeginTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置使用结束时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("endTimestamp")]
                        [System.Text.Json.Serialization.JsonPropertyName("endTimestamp")]
                        public long? EndTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置时间单位。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("timeUnit")]
                        [System.Text.Json.Serialization.JsonPropertyName("timeUnit")]
                        public int? TimeUnit { get; set; }

                        /// <summary>
                        /// 获取或设置时间值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("timeValue")]
                        [System.Text.Json.Serialization.JsonPropertyName("timeValue")]
                        public int? TimeValue { get; set; }

                        /// <summary>
                        /// 获取或设置领取开始时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("getStartTimestamp")]
                        [System.Text.Json.Serialization.JsonPropertyName("getStartTimestamp")]
                        public long GetBeginTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置领取结束时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("getEndTimestamp")]
                        [System.Text.Json.Serialization.JsonPropertyName("getEndTimestamp")]
                        public long GetEndTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置背景色。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("color")]
                [System.Text.Json.Serialization.JsonPropertyName("color")]
                public string? Color { get; set; }

                /// <summary>
                /// 获取或设置券码类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("codeType")]
                [System.Text.Json.Serialization.JsonPropertyName("codeType")]
                public int? CodeType { get; set; }

                /// <summary>
                /// 获取或设置有效期信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dateInfo")]
                [System.Text.Json.Serialization.JsonPropertyName("dateInfo")]
                public Types.DateInfo DateInfo { get; set; } = new Types.DateInfo();

                /// <summary>
                /// 获取或设置库存数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quantity")]
                [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                public int? Quantity { get; set; }

                /// <summary>
                /// 获取或设置每人领取次数限制。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("getLimit")]
                [System.Text.Json.Serialization.JsonPropertyName("getLimit")]
                public int? LimitCount { get; set; }

                /// <summary>
                /// 获取或设置领取渠道限制。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("limitChannel")]
                [System.Text.Json.Serialization.JsonPropertyName("limitChannel")]
                public int? LimitChannel { get; set; }

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
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("isMemberShip")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                public bool? IsMembership { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置卡券类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("couponType")]
        [System.Text.Json.Serialization.JsonPropertyName("couponType")]
        public string CouponType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门槛金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("leastCost")]
        [System.Text.Json.Serialization.JsonPropertyName("leastCost")]
        public int? LeastCost { get; set; }

        /// <summary>
        /// 获取或设置减免金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reduceCost")]
        [System.Text.Json.Serialization.JsonPropertyName("reduceCost")]
        public int? ReduceCost { get; set; }

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
        public Types.BaseInfo BaseInfo { get; set; } = new Types.BaseInfo();

        /// <summary>
        /// 获取或设置卡券描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置卡券领取事件回调 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("callbackUrl")]
        [System.Text.Json.Serialization.JsonPropertyName("callbackUrl")]
        public string CallbackUrl { get; set; } = string.Empty;
    }
}
