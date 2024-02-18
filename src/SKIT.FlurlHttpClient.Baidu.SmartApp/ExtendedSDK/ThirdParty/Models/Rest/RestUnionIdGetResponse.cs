namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/unionId/get 接口的响应。</para>
    /// </summary>
    public class RestUnionIdGetResponse : BaiduSmartAppThirdPartyResponse<RestUnionIdGetResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置用户的 UnionId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("union_id")]
                [System.Text.Json.Serialization.JsonPropertyName("union_id")]
                public string UnionId { get; set; } = default!;
            }
        }
    }
}
