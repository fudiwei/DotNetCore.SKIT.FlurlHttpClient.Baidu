using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.Auth
{
    public class GetUnionIdResponse : SmartAppResponse
    {
        [Newtonsoft.Json.JsonProperty("union_id")]
        [System.Text.Json.Serialization.JsonPropertyName("union_id")]
        public string UnionId { get; set; }
    }
}
