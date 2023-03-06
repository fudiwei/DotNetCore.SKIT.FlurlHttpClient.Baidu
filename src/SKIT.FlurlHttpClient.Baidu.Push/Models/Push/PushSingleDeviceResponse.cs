namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [POST] /push/single_device 接口的响应。</para>
    /// </summary>
    public class PushSingleDeviceResponse : BaiduPushResponse<PushSingleDeviceResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置消息 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msg_id")]
                [System.Text.Json.Serialization.JsonPropertyName("msg_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                public string MessageId { get; set; } = default!;

                /// <summary>
                /// 获取或设置推送时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("send_time")]
                [System.Text.Json.Serialization.JsonPropertyName("send_time")]
                public long SendTimestamp { get; set; }
            }
        }
    }
}
