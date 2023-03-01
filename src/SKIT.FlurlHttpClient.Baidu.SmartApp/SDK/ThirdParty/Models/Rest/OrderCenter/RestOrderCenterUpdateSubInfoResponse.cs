namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/ordercenter/update/sub/info 接口的响应。</para>
    /// </summary>
    public class RestOrderCenterUpdateSubInfoResponse : BaiduSmartAppThirdPartyResponse<RestOrderCenterUpdateSubInfoResponse.Types.Result[]>
    {
        public static class Types
        {
            public class Result : RestOrderCenterAppendSubInfoResponse.Types.Result
            {
            }
        }
    }
}
