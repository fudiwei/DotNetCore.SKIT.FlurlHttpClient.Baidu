namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty
{
    /// <summary>
    /// 表示百度智能小程序第三方平台 API 响应的基类。
    /// </summary>
    public abstract class BaiduSmartAppThirdPartyResponse : CommonResponseBase, ICommonResponse
    {
        /// <summary>
        /// 获取百度智能小程序第三方平台 API 返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errno")]
        [System.Text.Json.Serialization.JsonPropertyName("errno")]
        public virtual int ErrorNumber { get; set; }

        /// <summary>
        /// 获取百度智能小程序第三方平台 API 返回的错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public virtual string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取一个值，该值指示调用百度智能小程序第三方平台 API 是否成功。
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
    /// 表示百度智能小程序第三方平台 API 响应的基类。
    /// </summary>
    public abstract class BaiduSmartAppThirdPartyResponse<T> : BaiduSmartAppThirdPartyResponse
    {
        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public virtual T Data { get; set; } = default!;
    }
}
