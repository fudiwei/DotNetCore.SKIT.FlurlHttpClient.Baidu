namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [POST] /app/create_tag 接口的响应。</para>
    /// </summary>
    public class AppCreateTagResponse : BaiduPushResponse<AppCreateTagResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置标签名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tag")]
                [System.Text.Json.Serialization.JsonPropertyName("tag")]
                public string TagName { get; set; } = default!;

                /// <summary>
                /// 获取或设置结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result")]
                [System.Text.Json.Serialization.JsonPropertyName("result")]
                public int Result { get; set; }
            }
        }
    }
}
