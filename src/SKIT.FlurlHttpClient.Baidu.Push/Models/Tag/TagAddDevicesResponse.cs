namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [POST] /tag/add_devices 接口的响应。</para>
    /// </summary>
    public class TagAddDevicesResponse : BaiduPushResponse<TagAddDevicesResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Device
                    {
                        /// <summary>
                        /// 获取或设置设备 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("channel_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("channel_id")]
                        public string ChannelId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置结果。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("result")]
                        [System.Text.Json.Serialization.JsonPropertyName("result")]
                        public int Result { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置设备列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("devices")]
                [System.Text.Json.Serialization.JsonPropertyName("devices")]
                public Types.Device[] DeviceList { get; set; } = default!;
            }
        }
    }
}
