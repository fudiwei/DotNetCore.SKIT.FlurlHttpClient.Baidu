namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/ordercenter/update/main/info 接口的响应。</para>
    /// </summary>
    public class RestOrderCenterUpdateMainInfoResponse : BaiduSmartAppThirdPartyResponse<RestOrderCenterUpdateMainInfoResponse.Types.Result[]>
    {
        public static class Types
        {
            public class Result : RestOrderCenterAddMainInfoResponse.Types.Result
            {
            }
        }
    }
}
