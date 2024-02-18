namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/package/upload 接口的请求。</para>
    /// </summary>
    public class RestPackageUploadRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置第三方自定义的配置 JSON。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_json")]
        [System.Text.Json.Serialization.JsonPropertyName("ext_json")]
        public string ExtJson { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置代码模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public long TemplateId { get; set; }

        /// <summary>
        /// 获取或设置代码版本号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_version")]
        [System.Text.Json.Serialization.JsonPropertyName("user_version")]
        public string UserVersion { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置代码描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("user_desc")]
        public string UserDescription { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置测试帐号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("test_account")]
        [System.Text.Json.Serialization.JsonPropertyName("test_account")]
        public string? TestAccount { get; set; }

        /// <summary>
        /// 获取或设置测试密码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("test_password")]
        [System.Text.Json.Serialization.JsonPropertyName("test_password")]
        public string? TestPassword { get; set; }
    }
}
