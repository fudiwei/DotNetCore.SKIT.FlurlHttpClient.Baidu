namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/data/getanalysisterminal 接口的请求。</para>
    /// </summary>
    public class RestDataGetAnalysisTerminalRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int PageOffset { get; set; }

        /// <summary>
        /// 获取或设置开始日期字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string StartDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置结束日期字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string EndDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置终端数据类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string TerminalDataType { get; set; } = string.Empty;
    }
}
