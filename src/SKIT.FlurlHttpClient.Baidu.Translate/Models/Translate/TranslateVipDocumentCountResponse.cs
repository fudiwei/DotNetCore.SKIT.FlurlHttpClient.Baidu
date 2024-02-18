namespace SKIT.FlurlHttpClient.Baidu.Translate.Models
{
    /// <summary>
    /// <para>表示 [POST] /trans/vip/doccount 接口的响应。</para>
    /// </summary>
    public class TranslateVipDocumentCountResponse : BaiduTranslateResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置字符数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("charCount")]
                [System.Text.Json.Serialization.JsonPropertyName("charCount")]
                public int CharacterCount { get; set; }

                /// <summary>
                /// 获取或设置预估金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置文件 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fileId")]
                [System.Text.Json.Serialization.JsonPropertyName("fileId")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string FileId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
