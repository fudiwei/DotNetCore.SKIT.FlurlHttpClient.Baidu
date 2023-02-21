namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/package/get 接口的响应。</para>
    /// </summary>
    public class RestPackageGetResponse : BaiduSmartAppThirdPartyResponse<RestPackageGetResponse.Types.Package[]>
    {
        public static class Types
        {
            public class Package : RestPackageGetDetailResponse.Types.Data
            {
                /// <summary>
                /// 获取或设置上一个线上版本的版本号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rollback_version")]
                [System.Text.Json.Serialization.JsonPropertyName("rollback_version")]
                public string? RollbackVersion { get; set; }

                /// <summary>
                /// 获取或设置上传状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("upload_status")]
                [System.Text.Json.Serialization.JsonPropertyName("upload_status")]
                public int UploadStatus { get; set; }

                /// <summary>
                /// 获取或设置上传状态描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("upload_status_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("upload_status_desc")]
                public string? UploadStatusDescription { get; set; }

                /// <summary>
                /// 获取或设置上传失败错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("upload_err_code")]
                [System.Text.Json.Serialization.JsonPropertyName("upload_err_code")]
                public int? UploadErrorCode { get; set; }

                /// <summary>
                /// 获取或设置上传失败错误信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("upload_err_msg")]
                [System.Text.Json.Serialization.JsonPropertyName("upload_err_msg")]
                public string? UploadErrorMessage { get; set; }
            }
        }
    }
}
