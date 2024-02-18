namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/template/sendmessage 接口的响应。</para>
    /// </summary>
    public class RestTemplateSendMessageResponse : BaiduSmartAppThirdPartyResponse<RestTemplateSendMessageResponse.Types.Data>
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
    }
}
