namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/template/add 接口的响应。</para>
    /// </summary>
    public class RestTemplateAddResponse : BaiduSmartAppThirdPartyResponse<RestTemplateAddResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                public string TemplateId { get; set; } = default!;
            }
        }
    }
}
