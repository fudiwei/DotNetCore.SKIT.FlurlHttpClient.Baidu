namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Events
{
    /// <summary>
    /// <para>表示 PUSH.TICKET 事件的数据。</para>
    /// <para>REF: https://smartprogram.baidu.com/docs/third/auth/ticket/ </para>
    /// </summary>
    public class PushTicketEvent : BaiduSmartAppThirdPartyEvent
    {
        /// <summary>
        /// 获取或设置消息发送方账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("FromUserName")]
        [System.Text.Json.Serialization.JsonPropertyName("FromUserName")]
        public string FromUserName { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权方 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MsgType")]
        [System.Text.Json.Serialization.JsonPropertyName("MsgType")]
        public string MessageType { get; set; } = default!;

        /// <summary>
        /// 获取或设置消息创建时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CreateTime")]
        [System.Text.Json.Serialization.JsonPropertyName("CreateTime")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long CreateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置第三方授权票据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("Ticket")]
        public string Ticket { get; set; } = default!;
    }
}
