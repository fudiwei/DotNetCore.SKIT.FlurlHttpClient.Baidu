using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.Template
{
    public class GetTemplateListResponse : SmartAppResponse<GetTemplateListResponseData>
    {
    }

    public class GetTemplateListResponseData
    {
        [Newtonsoft.Json.JsonProperty("count")]
        [System.Text.Json.Serialization.JsonPropertyName("count")]
        public int Count { get; set; }

        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public List<GetTemplateListResponseListItem> List { get; set; }
    }

    public class GetTemplateListResponseListItem
    {
        [Newtonsoft.Json.JsonProperty("user_version")]
        [System.Text.Json.Serialization.JsonPropertyName("user_version")]
        public string UserVersion { get; set; }

        [Newtonsoft.Json.JsonProperty("user_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("user_desc")]
        public string UserDesc { get; set; }

        [Newtonsoft.Json.JsonProperty("create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        public long CreateTime { get; set; }

        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public int TemplateId { get; set; }

        [Newtonsoft.Json.JsonProperty("web_status")]
        [System.Text.Json.Serialization.JsonPropertyName("web_status")]
        public bool WebStatus { get; set; }
    }



}
