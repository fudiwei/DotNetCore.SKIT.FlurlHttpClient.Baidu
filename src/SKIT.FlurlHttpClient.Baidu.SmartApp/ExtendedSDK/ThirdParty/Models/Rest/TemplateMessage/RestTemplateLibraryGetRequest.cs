namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/template/library/get 接口的请求。</para>
    /// </summary>
    public class RestTemplateLibraryGetRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置模板标题 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Id { get; set; } = string.Empty;
    }
}
