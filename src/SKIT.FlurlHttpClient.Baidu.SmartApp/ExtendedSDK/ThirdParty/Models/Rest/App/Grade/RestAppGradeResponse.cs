namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/app/grade 接口的响应。</para>
    /// </summary>
    public class RestAppGradeResponse : BaiduSmartAppThirdPartyResponse<RestAppGradeResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class AppGrade
                    {
                        /// <summary>
                        /// 获取或设置小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string AppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序 AppKey。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_key")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_key")]
                        public string AppKey { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序等级。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("grade")]
                        [System.Text.Json.Serialization.JsonPropertyName("grade")]
                        public string Grade { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置分页页数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pageNo")]
                [System.Text.Json.Serialization.JsonPropertyName("pageNo")]
                public int PageNumber { get; set; }

                /// <summary>
                /// 获取或设置分页每页数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pageSize")]
                [System.Text.Json.Serialization.JsonPropertyName("pageSize")]
                public int PageSize { get; set; }

                /// <summary>
                /// 获取或设置小程序等级列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dataList")]
                [System.Text.Json.Serialization.JsonPropertyName("dataList")]
                public Types.AppGrade[] AppGradeList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置总页数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("totalPage")]
                [System.Text.Json.Serialization.JsonPropertyName("totalPage")]
                public int TotalPage { get; set; }
            }
        }
    }
}
