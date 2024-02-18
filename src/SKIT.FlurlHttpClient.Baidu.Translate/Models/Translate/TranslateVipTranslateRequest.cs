namespace SKIT.FlurlHttpClient.Baidu.Translate.Models
{
    /// <summary>
    /// <para>表示 [POST] /trans/vip/translate 接口的请求。</para>
    /// </summary>
    public class TranslateVipTranslateRequest : BaiduTranslateRequest
    {
        /// <summary>
        /// 获取或设置待翻译文本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("q")]
        [System.Text.Json.Serialization.JsonPropertyName("q")]
        public string QueryString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置翻译源语种代码。
        /// <para>默认值：auto</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("from")]
        [System.Text.Json.Serialization.JsonPropertyName("from")]
        public string From { get; set; } = "auto";

        /// <summary>
        /// 获取或设置翻译目标语种代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to")]
        [System.Text.Json.Serialization.JsonPropertyName("to")]
        public string To { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否显示语音合成资源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tts")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("tts")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? IsTTSRequired { get; set; }

        /// <summary>
        /// 获取或设置是否显示词典资源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dict")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("dict")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? IsDictionaryRequired { get; set; }

        /// <summary>
        /// 获取或设置是否使用自定义术语干预。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? IsActionRequired { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override long? Timestamp { get; set; }

        protected internal override string? GenerateSignature(Settings.Credentials credentials)
        {
            string msgText = string.Format("{0}{1}{2}{3}", credentials.AppId, QueryString, Salt, credentials.AppSecret);
            return Utilities.MD5Utility.Hash(msgText).Value!.ToLower();
        }
    }
}
