namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/ordercenter/update/sub/status 接口的响应。</para>
    /// </summary>
    public class RestOrderCenterUpdateSubStatusResponse : BaiduSmartAppThirdPartyResponse<RestOrderCenterUpdateSubStatusResponse.Types.Result[]>
    {
        public static class Types
        {
            public class Result : RestOrderCenterAppendSubInfoResponse.Types.Result
            {
            }
        }
    }
}
