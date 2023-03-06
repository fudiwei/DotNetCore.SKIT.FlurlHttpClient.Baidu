namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [POST] /tag/device_num 接口的响应。</para>
    /// </summary>
    public class TagDeviceNumberResponse : BaiduPushResponse<TagDeviceNumberResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置标签中设备的数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_num")]
                [System.Text.Json.Serialization.JsonPropertyName("device_num")]
                public int DeviceCount { get; set; }
            }
        }
    }
}
