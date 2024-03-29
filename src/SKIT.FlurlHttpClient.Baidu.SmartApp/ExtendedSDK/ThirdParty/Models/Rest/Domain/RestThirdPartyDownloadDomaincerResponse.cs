using System.Linq;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/tp/download/domaincer 接口的响应。</para>
    /// </summary>
    public class RestThirdPartyDownloadDomaincerResponse : BaiduSmartAppThirdPartyResponse
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && GetRawBytes().Any();
        }
    }
}
