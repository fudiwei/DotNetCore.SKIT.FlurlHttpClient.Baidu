namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [POST] /push/tags 接口的响应。</para>
    /// </summary>
    public class PushTagsResponse : BaiduPushResponse<PushTagsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : PushSingleDeviceResponse.Types.Data
            {
            }
        }
    }
}
