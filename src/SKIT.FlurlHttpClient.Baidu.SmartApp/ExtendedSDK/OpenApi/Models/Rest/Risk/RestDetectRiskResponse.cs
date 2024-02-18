namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/detectrisk 接口的响应。</para>
    /// </summary>
    public class RestDetectRiskResponse : BaiduSmartAppOpenApiResponse<RestDetectRiskResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置风险级别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("level")]
                [System.Text.Json.Serialization.JsonPropertyName("level")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int RiskLevel { get; set; }

                /// <summary>
                /// 获取或设置标签列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tag")]
                [System.Text.Json.Serialization.JsonPropertyName("tag")]
                public string[]? TagList { get; set; }
            }
        }
    }
}
