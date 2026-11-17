namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/ordercenter/update/sub/info 接口的响应。</para>
    /// </summary>
    public class RestOrderCenterUpdateSubInfoResponse : BaiduSmartAppThirdPartyResponse<List<RestOrderCenterUpdateSubInfoResponse.Types.Result>?>
    {
        public static class Types
        {
            public class Result : RestOrderCenterAddMainInfoResponse.Types.Result
            {
            }
        }
    }
}
