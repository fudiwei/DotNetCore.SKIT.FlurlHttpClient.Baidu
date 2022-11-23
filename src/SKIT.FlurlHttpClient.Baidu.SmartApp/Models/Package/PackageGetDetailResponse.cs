using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.Package
{
    public class PackageGetDetailResponse : SmartAppResponse<PackageGetDetailResponseData>
    {
    }

    public class PackageGetDetailResponseData
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
    }

}
