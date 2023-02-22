namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/package/release 接口的请求。</para>
    /// </summary>
    public class RestPackageReleaseRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置代码包 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package_id")]
        [System.Text.Json.Serialization.JsonPropertyName("package_id")]
        public long PackageId { get; set; }
    }
}
