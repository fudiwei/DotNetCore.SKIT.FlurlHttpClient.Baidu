namespace SKIT.FlurlHttpClient.Baidu.Translate.Models
{
    /// <summary>
    /// <para>表示 [POST] /trans/vip/language 接口的响应。</para>
    /// </summary>
    public class TranslateVipLanguageResponse : BaiduTranslateResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置检测语种代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("src")]
                [System.Text.Json.Serialization.JsonPropertyName("src")]
                public string Language { get; set; } = default!;
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
