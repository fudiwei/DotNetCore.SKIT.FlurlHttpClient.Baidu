namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Events
{
    /// <summary>
    /// <para>表示 IMAGE 事件的数据。</para>
    /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/contact_api_background/ </para>
    /// </summary>
    public class ImageMessageEvent : BaiduSmartAppOpenApiEvent, BaiduSmartAppOpenApiEvent.Serialization.IJsonSerializable, BaiduSmartAppOpenApiEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MsgId")]
        [System.Text.Json.Serialization.JsonPropertyName("MsgId")]
        [System.Xml.Serialization.XmlElement("MsgId")]
        public long MessageId { get; set; }

        /// <summary>
        /// 获取或设置图片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PicUrl")]
        [System.Text.Json.Serialization.JsonPropertyName("PicUrl")]
        [System.Xml.Serialization.XmlElement("PicUrl")]
        public string PictureUrl { get; set; } = default!;
    }
}
