namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty
{
    /// <summary>
    /// 表示百度智能小程序第三方平台 API 请求的基类。
    /// </summary>
    public abstract class BaiduSmartAppThirdPartyRequest : CommonRequestBase, ICommonRequest
    {
        /// <summary>
        /// 获取或设置百度智能小程序第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? AccessToken { get; set; }
    }
}
