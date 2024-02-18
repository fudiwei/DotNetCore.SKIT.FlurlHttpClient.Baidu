using System;
using System.Text;

namespace SKIT.FlurlHttpClient.Baidu.Translate.Models
{
    /// <summary>
    /// <para>表示 [POST] /trans/v2/voicetrans 接口的请求。</para>
    /// </summary>
    public class TranslateVoiceTranslateV2Request : BaiduTranslateRequest
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AppId { get; set; }

        /// <summary>
        /// 获取或设置经 Base64 编码的待翻译语音文件。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voice")]
        [System.Text.Json.Serialization.JsonPropertyName("voice")]
        public string EncodingVoiceData { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置音频文件格式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("format")]
        [System.Text.Json.Serialization.JsonPropertyName("format")]
        public string Format { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置翻译源语种代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("from")]
        [System.Text.Json.Serialization.JsonPropertyName("from")]
        public string From { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置翻译目标语种代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to")]
        [System.Text.Json.Serialization.JsonPropertyName("to")]
        public string To { get; set; } = string.Empty;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? Salt { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override long? Timestamp { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? Signature { get; set; }

        protected internal override string? GenerateSignature(Settings.Credentials credentials)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(credentials.AppSecret);
            byte[] msgBytes = Encoding.UTF8.GetBytes(string.Format("{0}{1}{2}", credentials.AppId, Timestamp, EncodingVoiceData));
            return Convert.ToBase64String(Utilities.HMACUtility.HashWithSHA256(keyBytes, msgBytes));
        }
    }
}
