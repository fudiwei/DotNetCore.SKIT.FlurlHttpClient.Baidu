namespace SKIT.FlurlHttpClient.Baidu.Translate
{
    /// <summary>
    /// 表示百度翻译开放平台 API 响应的基类。
    /// </summary>
    public abstract class BaiduTranslateResponse : CommonResponseBase, ICommonResponse
    {
        /// <summary>
        /// 获取百度翻译开放平台 API 返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_code")]
        [System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public virtual int ErrorCode { get; set; }

        /// <summary>
        /// 获取百度翻译开放平台 API 返回的错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("error_msg")]
        public virtual string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取一个值，该值指示调用百度翻译开放平台 API 是否成功。
        /// <para>
        ///（即 HTTP 状态码为 200，且 <see cref="ErrorCode"/> 值为 0/52000）
        /// </para>
        /// </summary>
        /// <returns></returns>
        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200 && (ErrorCode == 0 || ErrorCode == 52000);
        }
    }
}
