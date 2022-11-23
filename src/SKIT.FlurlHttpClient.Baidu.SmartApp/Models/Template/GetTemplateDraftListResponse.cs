using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.Template
{
    public class GetTemplateDraftListResponse : SmartAppResponse<GetTemplateDraftListResponseData>
    {
    }

    public class GetTemplateDraftListResponseData
    {
        [Newtonsoft.Json.JsonProperty("user_version")]
        [System.Text.Json.Serialization.JsonPropertyName("user_version")]
        public string UserVersion { get; set; }

        [Newtonsoft.Json.JsonProperty("user_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("user_desc")]
        public string UserDesc { get; set; }

        [Newtonsoft.Json.JsonProperty("create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        public int CreateTime { get; set; }

        [Newtonsoft.Json.JsonProperty("draft_id")]
        [System.Text.Json.Serialization.JsonPropertyName("draft_id")]
        public int DraftId { get; set; }

        [Newtonsoft.Json.JsonProperty("web_status")]
        [System.Text.Json.Serialization.JsonPropertyName("web_status")]
        public bool WebStatus { get; set; }
    }

}
