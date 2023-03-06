using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [POST] /tag/del_devices 接口的请求。</para>
    /// </summary>
    public class TagDeleteDevicesRequest : BaiduPushRequest
    {
        internal static class Converters
        {
            internal class RequestPropertyChannelIdListNewtonsoftJsonConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<IList<string>>
            {
            }

            internal class RequestPropertyChannelIdListSystemTextJsonConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<IList<string>>
            {
            }
        }

        /// <summary>
        /// 获取或设置标签名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag")]
        [System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string TagName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置设备 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_ids")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.RequestPropertyChannelIdListNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("channel_ids")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.RequestPropertyChannelIdListSystemTextJsonConverter))]
        public IList<string> ChannelIdList { get; set; } = new List<string>();
    }
}
