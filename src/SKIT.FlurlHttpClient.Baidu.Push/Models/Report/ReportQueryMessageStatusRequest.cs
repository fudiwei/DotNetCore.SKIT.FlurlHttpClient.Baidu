using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [GET] /report/query_msg_status 接口的请求。</para>
    /// </summary>
    public class ReportQueryMessageStatusRequest : BaiduPushRequest
    {
        /// <summary>
        /// 获取或设置消息 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonIgnore]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedObjectInJsonFormatConverter))]
        public IList<string> MessageIdList { get; set; } = new List<string>();
    }
}
