namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/pushmsg/getmsg 接口的响应。</para>
    /// </summary>
    public class RestPushMessageGetMessageResponse : BaiduSmartAppThirdPartyResponse<RestPushMessageGetMessageResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class EventMessage
                    {
                        /// <summary>
                        /// 获取或设置推送 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long EventMessageId { get; set; }

                        /// <summary>
                        /// 获取或设置加密后的推送内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string EncrtpyedContent { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置推送状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置推送消息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.EventMessage[] EventMessageList { get; set; } = default!;

                /// <summary>
                /// 获取或设置当前页数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page")]
                [System.Text.Json.Serialization.JsonPropertyName("page")]
                public int PageNumber { get; set; }

                /// <summary>
                /// 获取或设置当前每页数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pageSize")]
                [System.Text.Json.Serialization.JsonPropertyName("pageSize")]
                public int PageSize { get; set; }

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
