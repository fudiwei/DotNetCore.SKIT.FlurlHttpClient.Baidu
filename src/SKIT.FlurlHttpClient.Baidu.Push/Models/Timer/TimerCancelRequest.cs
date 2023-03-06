namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [POST] /timer/cancel 接口的请求。</para>
    /// </summary>
    public class TimerCancelRequest : BaiduPushRequest
    {
        /// <summary>
        /// 获取或设置定时任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timer_id")]
        [System.Text.Json.Serialization.JsonPropertyName("timer_id")]
        public string TimerId { get; set; } = string.Empty;
    }
}
