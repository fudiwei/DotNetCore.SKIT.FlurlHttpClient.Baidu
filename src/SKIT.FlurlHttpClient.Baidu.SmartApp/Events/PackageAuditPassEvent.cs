using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Events
{
    /// <summary>
    /// 代码包审核通过状态推送
    /// <para>REF: https://smartprogram.baidu.com/docs/third/package/push </para>
    /// </summary>
    public class PackageAuditPassEvent : SmartAppEvent
    {
        [Newtonsoft.Json.JsonProperty("packageId")]
        [System.Text.Json.Serialization.JsonPropertyName("packageId")]
        public string PackageId { get; set; }

        [Newtonsoft.Json.JsonProperty("packageVersion")]
        [System.Text.Json.Serialization.JsonPropertyName("packageVersion")]
        public string PackageVersion { get; set; }
    }
}
