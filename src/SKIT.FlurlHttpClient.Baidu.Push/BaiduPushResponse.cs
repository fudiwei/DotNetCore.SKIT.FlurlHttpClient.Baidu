namespace SKIT.FlurlHttpClient.Baidu.Push
{
    /// <summary>
    /// 表示百度云推送 API 响应的基类。
    /// </summary>
    public abstract class BaiduPushResponse : CommonResponseBase, ICommonResponse
    {
        /// <summary>
        /// 获取百度云推送 API 返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_code")]
        [System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public virtual int ErrorCode { get; set; }

        /// <summary>
        /// 获取百度云推送 API 返回的错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("error_msg")]
        public virtual string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置请求标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_id")]
        [System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public virtual long? RequestId { get; set; }

        /// <summary>
        /// 获取一个值，该值指示调用百度云推送 API 是否成功。
        /// <para>
        ///（即 HTTP 状态码为 200，且 <see cref="ErrorCode"/> 值为 0）
        /// </para>
        /// </summary>
        /// <returns></returns>
        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200 && ErrorCode == 0;
        }
    }

    /// <summary>
    /// 表示百度云推送 API 响应的基类。
    /// </summary>
    public abstract class BaiduPushResponse<T> : BaiduPushResponse
    {
        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("response_params")]
        [System.Text.Json.Serialization.JsonPropertyName("response_params")]
        public T Data { get; set; } = default!;
    }
}
