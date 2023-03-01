namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/getunionid 接口的响应。</para>
    /// </summary>
    public class RestGetUnionIdResponse : BaiduSmartAppOpenApiResponse<RestGetUnionIdResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置用户的 UnionId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unionid")]
                [System.Text.Json.Serialization.JsonPropertyName("unionid")]
                public string UnionId { get; set; } = default!;
            }
        }
    }
}
