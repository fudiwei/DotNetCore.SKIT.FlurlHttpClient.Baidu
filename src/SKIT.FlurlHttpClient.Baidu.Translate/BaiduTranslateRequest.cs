using System;

namespace SKIT.FlurlHttpClient.Baidu.Translate
{
    /// <summary>
    /// 表示百度翻译开放平台 API 请求的基类。
    /// </summary>
    public abstract class BaiduTranslateRequest : ICommonRequest
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。如果不指定将使用构造 <see cref="BaiduTranslateClient"/> 时的 <see cref="BaiduTranslateClientOptions.Timeout"/> 参数，这在需要指定特定耗时请求（比如上传或下载文件）的超时时间时很有用。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual int? Timeout { get; set; }

        /// <summary>
        /// 获取或设置百度翻译 AppId。如果不指定将使用构造 <see cref="BaiduTranslateClient"/> 时的 <see cref="BaiduTranslateClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public virtual string? AppId { get; set; }

        /// <summary>
        /// 获取或设置随机数。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("salt")]
        [System.Text.Json.Serialization.JsonPropertyName("salt")]
        public virtual string? Salt { get; set; }

        /// <summary>
        /// 获取或设置系统时间戳。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timestamp")]
        [System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public virtual long? Timestamp { get; set; }

        /// <summary>
        /// 获取或设置请求签名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign")]
        [System.Text.Json.Serialization.JsonPropertyName("sign")]
        public virtual string? Signature { get; set; }

        protected internal virtual string? GenerateSignature(Settings.Credentials credentials)
        {
            return null;
        }
    }
}
