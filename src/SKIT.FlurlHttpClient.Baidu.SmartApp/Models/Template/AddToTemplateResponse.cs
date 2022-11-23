using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.Template
{
    public class AddToTemplateResponse : SmartAppResponse<AddToTemplateResponseData>
    {
    }

    public class AddToTemplateResponseData
    {
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
