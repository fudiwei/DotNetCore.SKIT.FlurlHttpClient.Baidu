using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/subchain/rank 接口的请求。</para>
    /// </summary>
    public class RestSubchainRankRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置子链 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subchain_ranklist")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedNumberListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("subchain_ranklist")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedNumberListWithCommaSplitConverter))]
        public IList<long> SubchainIdList { get; set; } = new List<long>();
    }
}
