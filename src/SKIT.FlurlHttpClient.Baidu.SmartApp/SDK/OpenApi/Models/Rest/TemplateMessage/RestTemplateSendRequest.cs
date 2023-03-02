using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/template/send 接口的请求。</para>
    /// </summary>
    public class RestTemplateSendRequest : BaiduSmartAppOpenApiRequest
    {
        public static class Types
        {
            public class DataItem
            {
                /// <summary>
                /// 获取或设置关键词内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value")]
                [System.Text.Json.Serialization.JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
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

        /// <summary>
        /// 获取或设置场景 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_id")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_id")]
        public string? SceneId { get; set; }

        /// <summary>
        /// 获取或设置场景类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_type")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_type")]
        public int? SceneType { get; set; }
    }
}
