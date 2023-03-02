using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/access/submitresource 接口的请求。</para>
    /// </summary>
    public class RestAccessSubmitResourceRequest : BaiduSmartAppOpenApiRequest
    {
        internal static class Converters
        {
            internal class RequestPropertyImageListNewtonsoftJsonConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<IList<string>?>
            {
            }

            internal class RequestPropertyImageListSystemTextJsonConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<IList<string>?>
            {
            }
        }

        /// <summary>
        /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="BaiduSmartAppOpenApiClient"/> 时的 <see cref="BaiduSmartAppOpenApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置消息体。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("body")]
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public string Body { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置扩展信息 JSON 字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext")]
        [System.Text.Json.Serialization.JsonPropertyName("ext")]
        public string ExtraJson { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置信息流类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("feed_type")]
        [System.Text.Json.Serialization.JsonPropertyName("feed_type")]
        public string FeedType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置信息流子类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("feed_sub_type")]
        [System.Text.Json.Serialization.JsonPropertyName("feed_sub_type")]
        public string FeedSubType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置资源类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mapp_type")]
        [System.Text.Json.Serialization.JsonPropertyName("mapp_type")]
        public int ResourceType { get; set; }

        /// <summary>
        /// 获取或设置资源子类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mapp_sub_type")]
        [System.Text.Json.Serialization.JsonPropertyName("mapp_sub_type")]
        public int ResourceSubType { get; set; }

        /// <summary>
        /// 获取或设置封面图片 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("images")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.RequestPropertyImageListNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("images")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.RequestPropertyImageListSystemTextJsonConverter))]
        public IList<string> ImageUrlList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置资源标签列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tags")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("tags")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringListWithCommaSplitConverter))]
        public IList<string> TagList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置落地页页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path")]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public string PagePath { get; set; } = string.Empty;
    }
}
