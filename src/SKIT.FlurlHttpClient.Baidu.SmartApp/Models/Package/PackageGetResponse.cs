using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.Package
{
    public class PackageGetResponse : SmartAppResponse<List<PackageGetResponseData>>
    {
    }

    public class PackageGetResponseData
    {
        [Newtonsoft.Json.JsonProperty("version")]
        [System.Text.Json.Serialization.JsonPropertyName("version")]
        public string Version { get; set; }

        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string Remark { get; set; }

        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public string Message { get; set; }

        [Newtonsoft.Json.JsonProperty("committer")]
        [System.Text.Json.Serialization.JsonPropertyName("committer")]
        public string Committer { get; set; }

        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        [Newtonsoft.Json.JsonProperty("commit_time")]
        [System.Text.Json.Serialization.JsonPropertyName("commit_time")]
        public string CommitTime { get; set; }

        [Newtonsoft.Json.JsonProperty("version_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("version_desc")]
        public string VersionDesc { get; set; }

        [Newtonsoft.Json.JsonProperty("package_id")]
        [System.Text.Json.Serialization.JsonPropertyName("package_id")]
        public int PackageId { get; set; }

        [Newtonsoft.Json.JsonProperty("rollback_version")]
        [System.Text.Json.Serialization.JsonPropertyName("rollback_version")]
        public string RollbackVersion { get; set; }

        [Newtonsoft.Json.JsonProperty("upload_status")]
        [System.Text.Json.Serialization.JsonPropertyName("upload_status")]
        public int UploadStatus { get; set; }

        [Newtonsoft.Json.JsonProperty("upload_status_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("upload_status_desc")]
        public string UploadStatusDesc { get; set; }

        [Newtonsoft.Json.JsonProperty("upload_err_code")]
        [System.Text.Json.Serialization.JsonPropertyName("upload_err_code")]
        public int? UploadErrCode { get; set; }

        [Newtonsoft.Json.JsonProperty("upload_err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("upload_err_msg")]
        public string UploadErrMessage { get; set; }
    }

}
