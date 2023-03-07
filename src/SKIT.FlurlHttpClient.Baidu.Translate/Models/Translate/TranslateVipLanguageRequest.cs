namespace SKIT.FlurlHttpClient.Baidu.Translate.Models
{
    /// <summary>
    /// <para>表示 [POST] /trans/vip/language 接口的请求。</para>
    /// </summary>
    public class TranslateVipLanguageRequest : BaiduTranslateRequest
    {
        /// <summary>
        /// 获取或设置待翻译文本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("q")]
        [System.Text.Json.Serialization.JsonPropertyName("q")]
        public string QueryString { get; set; } = string.Empty;

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
