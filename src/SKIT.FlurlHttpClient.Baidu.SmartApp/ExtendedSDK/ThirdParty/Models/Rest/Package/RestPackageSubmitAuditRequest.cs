namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/package/submitaudit 接口的请求。</para>
    /// </summary>
    public class RestPackageSubmitAuditRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置代码包 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package_id")]
        [System.Text.Json.Serialization.JsonPropertyName("package_id")]
        public long PackageId { get; set; }

        /// <summary>
        /// 获取或设置送审描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string Remark { get; set; } = string.Empty;

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
