namespace SKIT.FlurlHttpClient.Baidu.Translate.Models
{
    /// <summary>
    /// <para>表示 [POST] /trans/sdk/picture 接口的响应。</para>
    /// </summary>
    public class TranslateSdkPictureResponse : BaiduTranslateResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Result
                    {
                        public static class Types
                        {
                            public class Point
                            {
                                /// <summary>
                                /// 获取或设置 X 轴坐标。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("x")]
                                [System.Text.Json.Serialization.JsonPropertyName("x")]
                                public int X { get; set; }

                                /// <summary>
                                /// 获取或设置 Y 轴坐标。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("y")]
                                [System.Text.Json.Serialization.JsonPropertyName("y")]
                                public int Y { get; set; }
                            }
                        }

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
                        /// 获取或设置识别文字的位置。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rect")]
                        [System.Text.Json.Serialization.JsonPropertyName("rect")]
                        public string Rectangle { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置识别文字的行数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("lineCount")]
                        [System.Text.Json.Serialization.JsonPropertyName("lineCount")]
                        public int LineCount { get; set; }

                        /// <summary>
                        /// 获取或设置经 Base64 编码的图片贴合数据。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pasteImg")]
                        [System.Text.Json.Serialization.JsonPropertyName("pasteImg")]
                        public string? EncodingPastedImageData { get; set; }

                        /// <summary>
                        /// 获取或设置译文矩形坐标列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("points")]
                        [System.Text.Json.Serialization.JsonPropertyName("points")]
                        public Types.Point[] PointList { get; set; } = default!;
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
                /// 获取或设置原文。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sumSrc")]
                [System.Text.Json.Serialization.JsonPropertyName("sumSrc")]
                public string Source { get; set; } = default!;

                /// <summary>
                /// 获取或设置译文。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sumDst")]
                [System.Text.Json.Serialization.JsonPropertyName("sumDst")]
                public string Destination { get; set; } = default!;

                /// <summary>
                /// 获取或设置翻译结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public Types.Result[] ResultList { get; set; } = default!;

                /// <summary>
                /// 获取或设置经 Base64 编码的图片贴合数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pasteImg")]
                [System.Text.Json.Serialization.JsonPropertyName("pasteImg")]
                public string? EncodingPastedImageData { get; set; }
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
