namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [POST] /push/batch_device 接口的响应。</para>
    /// </summary>
    public class PushBatchDeviceResponse : BaiduPushResponse<PushBatchDeviceResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : PushSingleDeviceResponse.Types.Data
            {
            }
        }
    }
}
