using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [GET] /report/query_msg_status 接口的请求。</para>
    /// </summary>
    public class ReportQueryMessageStatusRequest : BaiduPushRequest
    {
        internal static class Converters
        {
            internal class RequestPropertyMessageIdListNewtonsoftJsonConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<IList<string>>
            {
            }

            internal class RequestPropertyMessageIdListSystemTextJsonConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<IList<string>>
            {
            }
        }

        /// <summary>
        /// 获取或设置消息 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.RequestPropertyMessageIdListNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonIgnore]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.RequestPropertyMessageIdListSystemTextJsonConverter))]
        public IList<string> MessageIdList { get; set; } = new List<string>();
    }
}
