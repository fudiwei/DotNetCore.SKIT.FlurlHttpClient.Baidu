using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/app/category/update 接口的请求。</para>
    /// </summary>
    public class RestAppCategoryUpdateRequest : BaiduSmartAppThirdPartyRequest
    {
        public static class Types
        {
            public class Category
            {
                public static class Types
                {
                    public class Qualification
                    {
                        /// <summary>
                        /// 获取或设置资质项 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public int Id { get; set; }

                        /// <summary>
                        /// 获取或设置资质文件 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("addr")]
                        [System.Text.Json.Serialization.JsonPropertyName("addr")]
                        public string Url { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置子类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_category_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_category_id")]
                public int SubCategoryId { get; set; }

                /// <summary>
                /// 获取或设置类目资质列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualis")]
                [System.Text.Json.Serialization.JsonPropertyName("qualis")]
                public IList<Types.Qualification>? QualificationList { get; set; }
            }
        }

        internal static class Converters
        {
            internal class RequestPropertyCategoryListNewtonsoftJsonConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<IList<Types.Category>?>
            {
            }

            internal class RequestPropertyCategoryListSystemTextJsonConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<IList<Types.Category>?>
            {
            }
        }

        /// <summary>
        /// 获取或设置类目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("categorys")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.RequestPropertyCategoryListNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("categorys")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.RequestPropertyCategoryListSystemTextJsonConverter))]
        public IList<Types.Category> CategoryList { get; set; } = new List<Types.Category>();
    }
}
