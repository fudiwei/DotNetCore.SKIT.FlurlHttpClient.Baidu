namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/ordercenter/update/main/status 接口的响应。</para>
    /// </summary>
    public class RestOrderCenterUpdateMainStatusResponse : BaiduSmartAppThirdPartyResponse<RestOrderCenterUpdateMainStatusResponse.Types.Result[]>
    {
        public static class Types
        {
            public class Result : RestOrderCenterAddMainInfoResponse.Types.Result
            {
            }
        }
    }
}
