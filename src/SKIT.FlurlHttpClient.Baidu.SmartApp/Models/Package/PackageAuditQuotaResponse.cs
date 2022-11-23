using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.Package
{
    public class PackageAuditQuotaResponse : SmartAppResponse<PackageAuditQuotaResponseData>
    {
    }

    public class PackageAuditQuotaResponseData
    {
        [Newtonsoft.Json.JsonProperty("quota_type")]
        [System.Text.Json.Serialization.JsonPropertyName("quota_type")]
        public int QuotaType { get; set; }

        [Newtonsoft.Json.JsonProperty("quota_times")]
        [System.Text.Json.Serialization.JsonPropertyName("quota_times")]
        public int QuotaTimes { get; set; }

        [Newtonsoft.Json.JsonProperty("remain_times")]
        [System.Text.Json.Serialization.JsonPropertyName("remain_times")]
        public int RemainTimes { get; set; }
    }

}
