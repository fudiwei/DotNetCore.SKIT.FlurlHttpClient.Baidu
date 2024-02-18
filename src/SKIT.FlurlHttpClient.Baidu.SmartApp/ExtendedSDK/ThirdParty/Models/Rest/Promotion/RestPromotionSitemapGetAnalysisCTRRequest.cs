namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/promotion/sitemap/getanalysisctr 接口的请求。</para>
    /// </summary>
    public class RestPromotionSitemapGetAnalysisCTRRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置时间区间。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int TimeSpan { get; set; }
    }
}
