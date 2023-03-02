namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/ma/component/comment/open_list 接口的响应。</para>
    /// </summary>
    public class RestMAComponentCommentOpenListResponse : BaiduSmartAppOpenApiResponse<RestMAComponentCommentOpenListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Reply
                    {
                        /// <summary>
                        /// 获取或设置评论内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string Content { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置点赞数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("like_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("like_count")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int LikeCount { get; set; }

                        /// <summary>
                        /// 获取或设置是否已点赞。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_uped")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("is_uped")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool IsLiked { get; set; }
                    }

                    public class Comment : Reply
                    {
                        /// <summary>
                        /// 获取或设置主题 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("thread_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("thread_id")]
                        public string ThreadId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置评论 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("srid")]
                        [System.Text.Json.Serialization.JsonPropertyName("srid")]
                        public string CommentId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置回复列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reply_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("reply_list")]
                        public Types.Reply[]? ReplyList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置评论列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Comment[] CommentList { get; set; } = default!;
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取百度智能小程序 API 返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_code")]
        [System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public int ErrorCode { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ErrorCode == 0;
        }
    }
}
