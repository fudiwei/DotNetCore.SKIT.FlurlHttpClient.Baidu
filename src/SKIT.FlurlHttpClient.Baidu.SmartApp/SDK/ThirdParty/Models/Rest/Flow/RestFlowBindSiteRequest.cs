using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("sites")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringListWithCommaSplitConverter))]
        public IList<string> SiteList { get; set; } = new List<string>();
    }
}
