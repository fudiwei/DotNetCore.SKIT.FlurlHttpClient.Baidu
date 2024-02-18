namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/subchain/add 接口的请求。</para>
    /// </summary>
    public class RestSubchainAddRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置子链名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chain_name")]
        [System.Text.Json.Serialization.JsonPropertyName("chain_name")]
        public string SubchainName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子链描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chain_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("chain_desc")]
        public string SubchainDescription { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chain_path")]
        [System.Text.Json.Serialization.JsonPropertyName("chain_path")]
        public string? PagePath { get; set; }

        /// <summary>
        /// 获取或设置客服电话号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("telephone")]
        [System.Text.Json.Serialization.JsonPropertyName("telephone")]
        public string? PhoneNumber { get; set; }
    }
}
