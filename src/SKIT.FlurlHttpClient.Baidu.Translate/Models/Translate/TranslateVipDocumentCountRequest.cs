using System;
using System.Collections.Generic;
using System.Linq;

namespace SKIT.FlurlHttpClient.Baidu.Translate.Models
{
    /// <summary>
    /// <para>表示 [POST] /trans/vip/doccount 接口的请求。</para>
    /// </summary>
    public class TranslateVipDocumentCountRequest : BaiduTranslateRequest
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AppId { get; set; }

        /// <summary>
        /// 获取或设置待翻译文件类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string FileType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置待翻译文件名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? FileName { get; set; }

        /// <summary>
        /// 获取或设置待翻译文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] FileBytes { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// 获取或设置翻译源语种代码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string From { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置翻译目标语种代码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string To { get; set; } = string.Empty;

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
        public override string? Salt { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? Signature { get; set; }

        protected internal override string? GenerateSignature(Settings.Credentials credentials)
        {
            string msgText;

            IDictionary<string, string?> tmpParams = new SortedDictionary<string, string?>(StringComparer.Ordinal);
            tmpParams["appid"] = credentials.AppId;
            tmpParams["from"] = From;
            tmpParams["timestamp"] = Timestamp?.ToString();
            tmpParams["to"] = To;
            tmpParams["type"] = FileType;

            msgText = string.Join("&", tmpParams.Where(e => !string.IsNullOrEmpty(e.Value)).Select(e => $"{e.Key}={e.Value}")) + "&";

            if (FileBytes != null)
            {
                string fileMd5 = BitConverter.ToString(Utilities.MD5Utility.Hash(FileBytes)).Replace("-", "").ToLower();
                msgText += fileMd5;
            }

            msgText += credentials.AppSecret;

            return Utilities.MD5Utility.Hash(msgText).ToLower();
        }
    }
}
