namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/template/gettemplatedraftlist 接口的响应。</para>
    /// </summary>
    public class RestTemplateGetTemplateDraftListResponse : BaiduSmartAppThirdPartyResponse<RestTemplateGetTemplateDraftListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class TemplateDraft
                    {
                        /// <summary>
                        /// 获取或设置模板草稿 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("draft_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("draft_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long DraftId { get; set; }

                        /// <summary>
                        /// 获取或设置版本号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_version")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_version")]
                        public string UserVersion { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置自定义描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_desc")]
                        public string UserDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否支持 Web 化。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("web_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("web_status")]
                        public bool WebStatus { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置模板草稿列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.TemplateDraft[] TemplateDraftList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count")]
                [System.Text.Json.Serialization.JsonPropertyName("count")]
                public int TotalCount { get; set; }
            }
        }
    }
}
