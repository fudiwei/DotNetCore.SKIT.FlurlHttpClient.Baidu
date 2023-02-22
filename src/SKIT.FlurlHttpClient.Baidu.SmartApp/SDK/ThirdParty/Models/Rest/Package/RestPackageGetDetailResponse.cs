namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/package/getdetail 接口的响应。</para>
    /// </summary>
    public class RestPackageGetDetailResponse : BaiduSmartAppThirdPartyResponse<RestPackageGetDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置代码包 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_id")]
                [System.Text.Json.Serialization.JsonPropertyName("package_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long PackageId { get; set; }

                /// <summary>
                /// 获取或设置版本号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("version")]
                [System.Text.Json.Serialization.JsonPropertyName("version")]
                public string Version { get; set; } = default!;

                /// <summary>
                /// 获取或设置版本描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("version_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("version_desc")]
                public string? VersionDescription { get; set; }

                /// <summary>
                /// 获取或设置备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string Remark { get; set; } = default!;

                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置审核信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msg")]
                [System.Text.Json.Serialization.JsonPropertyName("msg")]
                public string? Message { get; set; }

                /// <summary>
                /// 获取或设置提交人。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("committer")]
                [System.Text.Json.Serialization.JsonPropertyName("committer")]
                public string? Committer { get; set; }

                /// <summary>
                /// 获取或设置提交时间字符串（格式：yyyy/MM/dd HH:mm:ss）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commit_time")]
                [System.Text.Json.Serialization.JsonPropertyName("commit_time")]
                public string? CommitTimeString { get; set; }
            }
        }
    }
}
