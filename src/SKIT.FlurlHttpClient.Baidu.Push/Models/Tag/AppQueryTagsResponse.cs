using System;

namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [GET] /app/query_tags 接口的响应。</para>
    /// </summary>
    public class AppQueryTagsResponse : BaiduPushResponse<AppQueryTagsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Tag
                    {
                        /// <summary>
                        /// 获取或设置标签 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tid")]
                        [System.Text.Json.Serialization.JsonPropertyName("tid")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string TagId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置标签名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tag")]
                        [System.Text.Json.Serialization.JsonPropertyName("tag")]
                        public string TagName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置描述标签的附件信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("info")]
                        [System.Text.Json.Serialization.JsonPropertyName("info")]
                        public string Information { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置标签类型。
                        /// </summary>
                        [Obsolete("相关接口或字段于 2015-05-01 下线。")]
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("createtime")]
                        [System.Text.Json.Serialization.JsonPropertyName("createtime")]
                        public long CreateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置标签列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tags")]
                [System.Text.Json.Serialization.JsonPropertyName("tags")]
                public Types.Tag[] TagList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_num")]
                [System.Text.Json.Serialization.JsonPropertyName("total_num")]
                public int TotalCount { get; set; }
            }
        }
    }
}
