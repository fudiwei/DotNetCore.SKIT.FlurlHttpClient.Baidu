using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/flow/bindsite 接口的请求。</para>
    /// </summary>
    public class RestFlowBindSiteRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置站点列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sites")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedStringListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("sites")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedStringListWithCommaSplitConverter))]
        public IList<string> SiteList { get; set; } = new List<string>();
    }
}
