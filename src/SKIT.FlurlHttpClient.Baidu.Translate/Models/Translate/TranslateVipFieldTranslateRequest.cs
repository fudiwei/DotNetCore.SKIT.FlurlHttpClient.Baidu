namespace SKIT.FlurlHttpClient.Baidu.Translate.Models
{
    /// <summary>
    /// <para>表示 [POST] /trans/vip/fieldtranslate 接口的请求。</para>
    /// </summary>
    public class TranslateVipFieldTranslateRequest : BaiduTranslateRequest
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
        /// 获取或设置翻译领域类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain")]
        [System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string Domain { get; set; } = string.Empty;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override long? Timestamp { get; set; }

        protected internal override string? GenerateSignature(Settings.Credentials credentials)
        {
            string msgText = string.Format("{0}{1}{2}{3}", credentials.AppId, QueryString, Salt, credentials.AppSecret);
            return Utilities.MD5Utility.Hash(msgText).ToLower();
        }
    }
}
