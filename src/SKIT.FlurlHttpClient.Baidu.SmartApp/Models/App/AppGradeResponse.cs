using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.App
{
    public class AppGradeResponse : SmartAppResponse<AppGradeResponseData>
    {
    }

    public class AppGradeResponseData
    {
        [Newtonsoft.Json.JsonProperty("pageNo")]
        [System.Text.Json.Serialization.JsonPropertyName("pageNo")]
        public int PageNo { get; set; }

        [Newtonsoft.Json.JsonProperty("pageSize")]
        [System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        public int PageSize { get; set; }

        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int Total { get; set; }

        [Newtonsoft.Json.JsonProperty("dataList")]
        [System.Text.Json.Serialization.JsonPropertyName("dataList")]
        public List<AppGradeResponseDataListItem> DataList { get; set; }

        [Newtonsoft.Json.JsonProperty("totalPage")]
        [System.Text.Json.Serialization.JsonPropertyName("totalPage")]
        public int TotalPage { get; set; }
    }

    public class AppGradeResponseDataListItem
    {
        [Newtonsoft.Json.JsonProperty("grade")]
        [System.Text.Json.Serialization.JsonPropertyName("grade")]
        public string Grade { get; set; }

        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public int AppId { get; set; }

        [Newtonsoft.Json.JsonProperty("app_key")]
        [System.Text.Json.Serialization.JsonPropertyName("app_key")]
        public string AppKey { get; set; }
    }
}
