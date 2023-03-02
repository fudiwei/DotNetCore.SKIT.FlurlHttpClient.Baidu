namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
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
                    public class Coupon : RestCouponGetResponse.Types.Data
                    {
                        public static new class Types
                        {
                            public class BaseInfo : RestCouponGetResponse.Types.Data.Types.BaseInfo
                            {
                                public static new class Types
                                {
                                    public class DateInfo : RestCouponGetResponse.Types.Data.Types.BaseInfo.Types.DateInfo
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置有效期信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("dateInfo")]
                                [System.Text.Json.Serialization.JsonPropertyName("dateInfo")]
                                public new Types.DateInfo DateInfo { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置卡券基础信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("baseInfo")]
                        [System.Text.Json.Serialization.JsonPropertyName("baseInfo")]
                        public new Types.BaseInfo BaseInfo { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置卡券列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dataList")]
                [System.Text.Json.Serialization.JsonPropertyName("dataList")]
                public Types.Coupon[] CouponList { get; set; } = default!;

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
