using System;

namespace SKIT.FlurlHttpClient.Baidu.Translate.Models
{
    /// <summary>
    /// <para>表示 [POST] /trans/sdk/picture 接口的请求。</para>
    /// </summary>
    public class TranslateSdkPictureRequest : BaiduTranslateRequest
    {
        /// <summary>
        /// 获取或设置待翻译图片文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] ImageFileBytes { get; set; } = Array.Empty<byte>();

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
        /// 获取或设置图片贴合类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("paste")]
        [System.Text.Json.Serialization.JsonPropertyName("paste")]
        public int? PasteType { get; set; }

        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cuid")]
        [System.Text.Json.Serialization.JsonPropertyName("cuid")]
        public string CUID { get; set; } = "APICUID";

        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mac")]
        [System.Text.Json.Serialization.JsonPropertyName("mac")]
        public string MAC { get; set; } = "mac";

        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version")]
        [System.Text.Json.Serialization.JsonPropertyName("version")]
        public int Version { get; set; } = 3;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override long? Timestamp { get; set; }

        protected internal override string? GenerateSignature(Settings.Credentials credentials)
        {
            string fileMd5 = BitConverter.ToString(Utilities.MD5Utility.Hash(ImageFileBytes ?? Array.Empty<byte>())).Replace("-", "").ToLower();
            string msgText = string.Format("{0}{1}{2}{3}{4}{5}", credentials.AppId, fileMd5, Salt, CUID, MAC, credentials.AppSecret);
            return Utilities.MD5Utility.Hash(msgText).Value!.ToLower();
        }
    }
}
