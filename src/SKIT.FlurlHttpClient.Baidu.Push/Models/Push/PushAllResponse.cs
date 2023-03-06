namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [POST] /push/all 接口的响应。</para>
    /// </summary>
    public class PushAllResponse : BaiduPushResponse<PushAllResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : PushSingleDeviceResponse.Types.Data
            {
            }
        }
    }
}
