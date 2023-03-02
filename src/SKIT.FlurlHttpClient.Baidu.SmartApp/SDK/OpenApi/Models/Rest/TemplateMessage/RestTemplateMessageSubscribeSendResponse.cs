namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/template/message/subscribe/send 接口的响应。</para>
    /// </summary>
    public class RestTemplateMessageSubscribeSendResponse : BaiduSmartAppOpenApiResponse<RestTemplateMessageSubscribeSendResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置消息 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msg_key")]
                [System.Text.Json.Serialization.JsonPropertyName("msg_key")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long MessageId { get; set; }
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
