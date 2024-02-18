namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/package/withdraw 接口的请求。</para>
    /// </summary>
    public class RestPackageWithdrawRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置代码包 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package_id")]
        [System.Text.Json.Serialization.JsonPropertyName("package_id")]
        public long PackageId { get; set; }
    }
}
