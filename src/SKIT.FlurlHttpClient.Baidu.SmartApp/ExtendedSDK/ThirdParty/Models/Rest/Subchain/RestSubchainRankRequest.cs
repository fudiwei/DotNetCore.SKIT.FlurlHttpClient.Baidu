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
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("subchain_ranklist")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberListWithCommaSplitConverter))]
        public List<long>? SubchainIdList { get; set; }
    }
}
