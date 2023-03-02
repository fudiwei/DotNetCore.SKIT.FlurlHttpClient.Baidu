namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/template/libraryget 接口的响应。</para>
    /// </summary>
    public class RestTemplateLibraryGetResponse : BaiduSmartAppOpenApiResponse<RestTemplateLibraryGetResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Keyword
                    {
                        /// <summary>
                        /// 获取或设置关键词 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("keyword_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("keyword_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int KeywordId { get; set; }

                        /// <summary>
                        /// 获取或设置关键词内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置关键词内容示例。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("example")]
                        [System.Text.Json.Serialization.JsonPropertyName("example")]
                        public string? Example { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置模板标题 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string Id { get; set; } = default!;

                /// <summary>
                /// 获取或设置模板标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置关键词数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("keyword_count")]
                [System.Text.Json.Serialization.JsonPropertyName("keyword_count")]
                public int KeywordCount { get; set; }

                /// <summary>
                /// 获取或设置关键词列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("keyword_list")]
                [System.Text.Json.Serialization.JsonPropertyName("keyword_list")]
                public Types.Keyword[] KeywordList { get; set; } = default!;
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
