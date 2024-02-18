namespace SKIT.FlurlHttpClient.Baidu.Push
{
    /// <summary>
    /// 表示百度云推送 API 请求的基类。
    /// </summary>
    public abstract class BaiduPushRequest : CommonRequestBase, ICommonRequest
    {
        /// <summary>
        /// 获取或设置设备平台类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_type")]
        [System.Text.Json.Serialization.JsonPropertyName("device_type")]
        public virtual int? DeviceType { get; set; }
    }
}
