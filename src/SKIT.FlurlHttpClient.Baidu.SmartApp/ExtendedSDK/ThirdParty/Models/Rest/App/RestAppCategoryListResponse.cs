using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/app/category/list 接口的响应。</para>
    /// </summary>
    public class RestAppCategoryListResponse : BaiduSmartAppThirdPartyResponse<RestAppCategoryListResponse.Types.Category[]>
    {
        public static class Types
        {
            public class Category
            {
                public static class Types
                {
                    public class SubCategory
                    {
                        public static class Types
                        {
                            public class QualificationItem
                            {
                                /// <summary>
                                /// 获取或设置资质项 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public int Id { get; set; }

                                /// <summary>
                                /// 获取或设置资质项名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置资质项描述。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("desc")]
                                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                                public string Description { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置是否必须。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("must")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("must")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                                public bool IsRequired { get; set; }
                            }

                            public class QualificationList
                            {
                                /// <summary>
                                /// 获取或设置资质描述。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("desc")]
                                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                                public string Description { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置资质列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("list")]
                                [System.Text.Json.Serialization.JsonPropertyName("list")]
                                public Types.QualificationItem[] Items { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置子类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int CategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置子类目类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_type")]
                        public int CategoryType { get; set; }

                        /// <summary>
                        /// 获取或设置子类目名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_name")]
                        public string CategoryName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否需要资质。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("need_quali")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("need_quali")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                        public bool RequireQualification { get; set; }

                        /// <summary>
                        /// 获取或设置类目所需资质信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_quali")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedObjectInJsonFormatConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("category_quali")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedObjectInJsonFormatConverter))]
                        public Types.QualificationList? QualificationList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int CategoryId { get; set; }

                /// <summary>
                /// 获取或设置类目类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_type")]
                [System.Text.Json.Serialization.JsonPropertyName("category_type")]
                public int CategoryType { get; set; }

                /// <summary>
                /// 获取或设置类目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_name")]
                [System.Text.Json.Serialization.JsonPropertyName("category_name")]
                public string CategoryName { get; set; } = default!;

                /// <summary>
                /// 获取或设置子类目字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_items")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_items")]
                public IDictionary<int, Types.SubCategory>? SubCategoryMap { get; set; }
            }
        }
    }
}
