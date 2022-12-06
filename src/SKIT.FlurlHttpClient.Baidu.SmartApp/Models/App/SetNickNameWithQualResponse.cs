using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.App
{
    public class SetNickNameWithQualResponse : SmartAppResponse<SetNickNameWithQualResponseData>
    {
    }

    public class SetNickNameWithQualResponseData
    {
        [Newtonsoft.Json.JsonProperty("examine_id")]
        [System.Text.Json.Serialization.JsonPropertyName("examine_id")]
        public int ExamineId { get; set; }
    }
}
