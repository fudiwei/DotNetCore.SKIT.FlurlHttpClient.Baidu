namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [GET] /report/statistic_device 接口的请求。</para>
    /// </summary>
    public class ReportStatisticDeviceRequest : BaiduPushRequest
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override int? DeviceType { get; set; }
    }
}
