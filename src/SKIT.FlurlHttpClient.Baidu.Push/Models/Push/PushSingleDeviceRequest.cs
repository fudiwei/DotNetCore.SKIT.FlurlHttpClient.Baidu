using System.Collections;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [POST] /push/single_device 接口的请求。</para>
    /// </summary>
    public class PushSingleDeviceRequest : BaiduPushRequest
    {
        public static class Types
        {
            public class Message : IDictionary<string, object?>
            {
                private readonly IDictionary<string, object?> _dict = new Dictionary<string, object?>();

                public object? this[string key]
                {
                    get { return _dict[key]; }
                    set { _dict[key] = value; }
                }

                ICollection<string> IDictionary<string, object?>.Keys
                {
                    get { return _dict.Keys; }
                }

                ICollection<object?> IDictionary<string, object?>.Values
                {
                    get { return _dict.Values; }
                }

                int ICollection<KeyValuePair<string, object?>>.Count
                {
                    get { return _dict.Count; }
                }

                bool ICollection<KeyValuePair<string, object?>>.IsReadOnly
                {
                    get { return _dict.IsReadOnly; }
                }

                public void Add(string key, object? value)
                {
                    _dict.Add(key, value);
                }

                public void Add(KeyValuePair<string, object?> item)
                {
                    _dict.Add(item);
                }

                public bool ContainsKey(string key)
                {
                    return _dict.ContainsKey(key);
                }

                public bool Contains(KeyValuePair<string, object?> item)
                {
                    return _dict.Contains(item);
                }

                public bool Remove(string key)
                {
                    return _dict.Remove(key);
                }

                public bool Remove(KeyValuePair<string, object?> item)
                {
                    return _dict.Remove(item);
                }

                public void Clear()
                {
                    _dict.Clear();
                }

                public bool TryGetValue(string key, out object? value)
                {
                    return _dict.TryGetValue(key, out value);
                }

                void ICollection<KeyValuePair<string, object?>>.CopyTo(KeyValuePair<string, object?>[] array, int arrayIndex)
                {
                    _dict.CopyTo(array, arrayIndex);
                }

                IEnumerator<KeyValuePair<string, object?>> IEnumerable<KeyValuePair<string, object?>>.GetEnumerator()
                {
                    return _dict.GetEnumerator();
                }

                IEnumerator IEnumerable.GetEnumerator()
                {
                    return ((IEnumerable)_dict).GetEnumerator();
                }
            }
        }

        /// <summary>
        /// 获取或设置设备 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_id")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_id")]
        public string ChannelId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_type")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_type")]
        public int? MessageType { get; set; }

        /// <summary>
        /// 获取或设置消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedObjectInJsonFormatConverter))]
        public Types.Message? Message { get; set; }

        /// <summary>
        /// 获取或设置消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extra_msg_type")]
        [System.Text.Json.Serialization.JsonPropertyName("extra_msg_type")]
        public int? ExtraMessageType { get; set; }

        /// <summary>
        /// 获取或设置消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extra_msg")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("extra_msg")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedObjectInJsonFormatConverter))]
        public Types.Message? ExtraMessage { get; set; }

        /// <summary>
        /// 获取或设置分类主题 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("topic_id")]
        [System.Text.Json.Serialization.JsonPropertyName("topic_id")]
        public string? TopicId { get; set; }

        /// <summary>
        /// 获取或设置消息有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_expires")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_expires")]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// 获取或设置 iOS 应用部署状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deploy_status")]
        [System.Text.Json.Serialization.JsonPropertyName("deploy_status")]
        public int? DeployStatus { get; set; }

        /// <summary>
        /// 获取或设置通道类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_type")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_type")]
        public int? ChannelType { get; set; }
    }
}
