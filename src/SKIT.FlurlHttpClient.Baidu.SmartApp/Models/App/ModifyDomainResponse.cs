using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.App
{
    public class ModifyDomainResponse : SmartAppResponse
    {
        [Newtonsoft.Json.JsonProperty("download_domain")]
        [System.Text.Json.Serialization.JsonPropertyName("download_domain")]
        public string DownloadDomain { get; set; }

        [Newtonsoft.Json.JsonProperty("request_domain")]
        [System.Text.Json.Serialization.JsonPropertyName("request_domain")]
        public string RequestDomain { get; set; }

        [Newtonsoft.Json.JsonProperty("socket_domain")]
        [System.Text.Json.Serialization.JsonPropertyName("socket_domain")]
        public string SocketDomain { get; set; }

        [Newtonsoft.Json.JsonProperty("upload_domain")]
        [System.Text.Json.Serialization.JsonPropertyName("upload_domain")]
        public string UploadDomain { get; set; }
    }
}
