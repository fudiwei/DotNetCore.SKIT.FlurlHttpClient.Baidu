using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.Template
{
    public class DelTemplateResponse : SmartAppResponse<DelTemplateResponseData>
    {

    }

    public class DelTemplateResponseData
    {
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public int Result { get; set; }
    }
}
