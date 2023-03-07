namespace SKIT.FlurlHttpClient.Baidu.Translate.Models
{
    /// <summary>
    /// <para>表示 [POST] /trans/vip/doctrans 接口的响应。</para>
    /// </summary>
    public class TranslateVipDocumentTranslateResponse : BaiduTranslateResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置翻译请求 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("requestId")]
                [System.Text.Json.Serialization.JsonPropertyName("requestId")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                public string RequestId { get; set; } = default!;
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
