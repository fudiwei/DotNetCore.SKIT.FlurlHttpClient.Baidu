namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/package/getdetail 接口的请求。</para>
    /// </summary>
    public class RestPackageGetDetailRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置小程序类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Type { get; set; }

        /// <summary>
        /// 获取或设置代码包 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long? PackageId { get; set; }
    }
}
