namespace SKIT.FlurlHttpClient.Baidu.Translate.Models
{
    /// <summary>
    /// <para>表示 [POST] /trans/v2/voicetrans 接口的响应。</para>
    /// </summary>
    public class TranslateVoiceTranslateV2Response : BaiduTranslateResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置原文。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source")]
                [System.Text.Json.Serialization.JsonPropertyName("source")]
                public string Source { get; set; } = default!;

                /// <summary>
                /// 获取或设置译文。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("target")]
                [System.Text.Json.Serialization.JsonPropertyName("target")]
                public string Destination { get; set; } = default!;

                /// <summary>
                /// 获取或设置经 Base64 编码的译文 TTS。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("target_tts")]
                [System.Text.Json.Serialization.JsonPropertyName("target_tts")]
                public string? EncodingDestinationTTSData { get; set; }
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public override int ErrorCode { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
