using System.Linq;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/app/qrcode 接口的响应。</para>
    /// </summary>
    public class RestAppQrcodeResponse : BaiduSmartAppThirdPartyResponse
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && GetRawBytes().Any();
        }
    }
}
