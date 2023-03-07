namespace SKIT.FlurlHttpClient.Baidu.Translate.Models
{
    /// <summary>
    /// <para>表示 [POST] /trans/vip/fieldtranslate 接口的响应。</para>
    /// </summary>
    public class TranslateVipFieldTranslateResponse : BaiduTranslateResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置原文。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("src")]
                [System.Text.Json.Serialization.JsonPropertyName("src")]
                public string Source { get; set; } = default!;

                /// <summary>
                /// 获取或设置译文。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dst")]
                [System.Text.Json.Serialization.JsonPropertyName("dst")]
                public string Destination { get; set; } = default!;

                /// <summary>
                /// 获取或设置原文 TTS 链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("src_tts")]
                [System.Text.Json.Serialization.JsonPropertyName("src_tts")]
                public string? SourceTTSUrl { get; set; }

                /// <summary>
                /// 获取或设置译文 TTS 链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dst_tts")]
                [System.Text.Json.Serialization.JsonPropertyName("dst_tts")]
                public string? DestinationTTSUrl { get; set; }

                /// <summary>
                /// 获取或设置中英词典资源 JSON 字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dict")]
                [System.Text.Json.Serialization.JsonPropertyName("dict")]
                public string? DictionaryJson { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置翻译源语种代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("from")]
        [System.Text.Json.Serialization.JsonPropertyName("from")]
        public string From { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻译目标语种代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to")]
        [System.Text.Json.Serialization.JsonPropertyName("to")]
        public string To { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻译结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trans_result")]
        [System.Text.Json.Serialization.JsonPropertyName("trans_result")]
        public Types.Result[] ResultList { get; set; } = default!;
    }
}
