namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi
{
    /// <summary>
    /// 表示百度智能小程序 API 响应的基类。
    /// </summary>
    public abstract class BaiduSmartAppOpenApiResponse : CommonResponseBase, ICommonResponse
    {
        /// <summary>
        /// 获取百度智能小程序 API 返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errno")]
        [System.Text.Json.Serialization.JsonPropertyName("errno")]
        public virtual int ErrorNumber { get; set; }

        /// <summary>
        /// 获取百度智能小程序 API 返回的错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errmsg")]
        [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
        public virtual string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置请求标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_id")]
        [System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public virtual string? RequestId { get; set; }

        /// <summary>
        /// 获取或设置请求时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timestamp")]
        [System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public virtual long? RequestTimestamp { get; set; }

        /// <summary>
        /// 获取一个值，该值指示调用百度智能小程序 API 是否成功。
        /// <para>
        ///（即 HTTP 状态码为 200，且 <see cref="ErrorNumber"/> 值为 0）
        /// </para>
        /// </summary>
        /// <returns></returns>
        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200 && ErrorNumber == 0;
        }
    }

    /// <summary>
    /// 表示百度智能小程序 API 响应的基类。
    /// </summary>
    public abstract class BaiduSmartAppOpenApiResponse<T> : BaiduSmartAppOpenApiResponse
    {
        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public T Data { get; set; } = default!;
    }
}
