namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [GET] /timer/query_list 接口的请求。</para>
    /// </summary>
    public class TimerQueryListRequest : BaiduPushRequest
    {
        /// <summary>
        /// 获取或设置定时任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? TimerId { get; set; }

        /// <summary>
        /// 获取或设置返回记录的起始索引位置。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Start { get; set; }

        /// <summary>
        /// 获取或设置返回记录的条数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Limit { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override int? DeviceType { get; set; }
    }
}
