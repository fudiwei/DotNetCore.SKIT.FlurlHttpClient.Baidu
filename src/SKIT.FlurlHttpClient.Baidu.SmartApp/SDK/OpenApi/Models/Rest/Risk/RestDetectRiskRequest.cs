using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/detectrisk 接口的请求。</para>
    /// </summary>
    public class RestDetectRiskRequest : BaiduSmartAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置小程序 AppKey。如果不指定将使用构造 <see cref="BaiduSmartAppOpenApiClient"/> 时的 <see cref="BaiduSmartAppOpenApiClientOptions.AppKey"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appkey")]
        [System.Text.Json.Serialization.JsonPropertyName("appkey")]
        public string? AppKey { get; set; }

        /// <summary>
        /// 获取或设置小程序通过 swan.getSystemRiskInfo 获取的内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("xtoken")]
        [System.Text.Json.Serialization.JsonPropertyName("xtoken")]
        public string XToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置经营活动类型。
        /// <para>默认值：marketing</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "marketing";

        /// <summary>
        /// 获取或设置事件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ev")]
        [System.Text.Json.Serialization.JsonPropertyName("ev")]
        public string Event { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置客户端的 IP。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("clientip")]
        [System.Text.Json.Serialization.JsonPropertyName("clientip")]
        public string ClientIP { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置客户端的 User-Agent。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("useragent")]
        [System.Text.Json.Serialization.JsonPropertyName("useragent")]
        public string? ClientUserAgent { get; set; }

        /// <summary>
        /// 获取或设置电话号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone")]
        [System.Text.Json.Serialization.JsonPropertyName("phone")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// 获取或设置时间戳。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ts")]
        [System.Text.Json.Serialization.JsonPropertyName("ts")]
        public long? Timestamp { get; set; }
    }
}
