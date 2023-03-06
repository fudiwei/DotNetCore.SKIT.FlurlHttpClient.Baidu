namespace SKIT.FlurlHttpClient.Baidu.Push
{
    /// <summary>
    /// 表示百度云推送 API 请求的基类。
    /// </summary>
    public abstract class BaiduPushRequest : ICommonRequest
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。如果不指定将使用构造 <see cref="BaiduPushClient"/> 时的 <see cref="BaiduPushClientOptions.Timeout"/> 参数，这在需要指定特定耗时请求（比如上传或下载文件）的超时时间时很有用。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual int? Timeout { get; set; }

        /// <summary>
        /// 获取或设置设备平台类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_type")]
        [System.Text.Json.Serialization.JsonPropertyName("device_type")]
        public virtual int? DeviceType { get; set; }
    }
}
