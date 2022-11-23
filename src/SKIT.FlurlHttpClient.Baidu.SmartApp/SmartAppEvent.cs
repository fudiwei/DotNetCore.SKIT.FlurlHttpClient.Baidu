using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp
{
    public class SmartAppEvent
    {
        /// <summary>
        /// 小程序appid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appId")]
        [System.Text.Json.Serialization.JsonPropertyName("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// 第三方平台appid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tpAppId")]
        [System.Text.Json.Serialization.JsonPropertyName("tpAppId")]
        public string TpAppId { get; set; }

        [Newtonsoft.Json.JsonProperty("event")]
        [System.Text.Json.Serialization.JsonPropertyName("event")]
        public string @Event { get; set; }

        [Newtonsoft.Json.JsonProperty("eventTime")]
        [System.Text.Json.Serialization.JsonPropertyName("eventTime")]
        public string EventTime { get; set; }

        /// <summary>
        /// 解密字符串
        /// </summary>
        public string DecryptData { get; set; }

        public virtual Dictionary<string, string> ToDictionary()
        {
            if (string.IsNullOrWhiteSpace(this.DecryptData))
                throw new ArgumentNullException(nameof(this.DecryptData));

            var j = JsonConvert.DeserializeObject<JObject>(this.DecryptData);

            var kvs = ((IDictionary<string, JToken>)j).ToDictionary(x => x.Key, v => v.Value?.ToString());

            return kvs;
        }
    }
}
