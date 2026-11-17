namespace SKIT.FlurlHttpClient.Baidu.Translate.Models
{
    /// <summary>
    /// <para>表示 [POST] /trans/vip/doccount 接口的请求。</para>
    /// </summary>
    public class TranslateVipDocumentCountRequest : BaiduTranslateRequest
    {
        /// <inheritdoc/>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AppId { get; set; }

        /// <summary>
        /// 获取或设置待翻译文件类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? FileType { get; set; }

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
        public byte[]? FileBytes { get; set; }

        /// <summary>
        /// 获取或设置翻译源语种代码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? From { get; set; }

        /// <summary>
        /// 获取或设置翻译目标语种代码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? To { get; set; }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override long? Timestamp { get; set; }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? Salt { get; set; }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? Signature { get; set; }

        protected internal override string? GenerateSignature(Settings.Credentials credentials)
        {
            string msgText;

            SortedDictionary<string, string?> sortedParams = new(StringComparer.Ordinal);
            sortedParams["appid"] = credentials.AppId;
            sortedParams["from"] = From;
            sortedParams["timestamp"] = Timestamp?.ToString();
            sortedParams["to"] = To;
            sortedParams["type"] = FileType;

            msgText = string.Join("&", sortedParams.Where(e => !string.IsNullOrEmpty(e.Value)).Select(e => $"{e.Key}={e.Value}")) + "&";

            if (FileBytes is not null)
            {
                string fileMd5 = BitConverter.ToString(Utilities.MD5Utility.Hash(FileBytes)).Replace("-", "").ToLower();
                msgText += fileMd5;
            }

            msgText += credentials.AppSecret;

            return Utilities.MD5Utility.Hash(msgText).Value!.ToLower();
        }
    }
}
