namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/app/checknamewithqual 接口的响应。</para>
    /// </summary>
    public class RestAppCheckNameWithQualificationResponse : BaiduSmartAppThirdPartyResponse<RestAppCheckNameWithQualificationResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置检测结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("checkResult")]
                [System.Text.Json.Serialization.JsonPropertyName("checkResult")]
                public int CheckResult { get; set; }

                /// <summary>
                /// 获取或设置命中关键词列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("checkWords")]
                [System.Text.Json.Serialization.JsonPropertyName("checkWords")]
                public string[]? CheckWordList { get; set; }

                /// <summary>
                /// 获取或设置当前名称必须要上传的资质字段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("requiredFields")]
                [System.Text.Json.Serialization.JsonPropertyName("requiredFields")]
                public int[]? RequiredFieldList { get; set; }

                /// <summary>
                /// 获取或设置当前名称可上传的资质字段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("optionalFields")]
                [System.Text.Json.Serialization.JsonPropertyName("optionalFields")]
                public int[]? OptionalFieldList { get; set; }
            }
        }
    }
}
