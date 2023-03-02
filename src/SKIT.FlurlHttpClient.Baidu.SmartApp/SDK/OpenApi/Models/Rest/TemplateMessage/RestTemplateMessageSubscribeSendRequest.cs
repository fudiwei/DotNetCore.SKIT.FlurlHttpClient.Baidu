using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/template/message/subscribe/send 接口的请求。</para>
    /// </summary>
    public class RestTemplateMessageSubscribeSendRequest : BaiduSmartAppOpenApiRequest
    {
        public static class Types
        {
            public class DataItem : RestTemplateSendRequest.Types.DataItem
            {
            }
        }

        internal static class Converters
        {
            internal class RequestPropertyDataNewtonsoftJsonConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<IDictionary<string, Types.DataItem>?>
            {
            }

            internal class RequestPropertDataSystemTextJsonConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<IDictionary<string, Types.DataItem>?>
            {
            }
        }

        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string TemplateId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置接收者用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("touser_openId")]
        [System.Text.Json.Serialization.JsonPropertyName("touser_openId")]
        public string ToUserOpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订阅 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subscribe_id")]
        [System.Text.Json.Serialization.JsonPropertyName("subscribe_id")]
        public string SubscribeId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置消息关键词字典。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.RequestPropertyDataNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.RequestPropertDataSystemTextJsonConverter))]
        public IDictionary<string, Types.DataItem> Data { get; set; } = new Dictionary<string, Types.DataItem>();

        /// <summary>
        /// 获取或设置小程序页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public string? PagePath { get; set; }
    }
}
