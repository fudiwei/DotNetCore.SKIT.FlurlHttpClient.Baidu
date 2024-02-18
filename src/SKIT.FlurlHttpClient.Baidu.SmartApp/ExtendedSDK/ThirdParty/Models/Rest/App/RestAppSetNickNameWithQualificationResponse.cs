namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/app/setnicknamewithqual 接口的响应。</para>
    /// </summary>
    public class RestAppSetNickNameWithQualificationResponse : BaiduSmartAppThirdPartyResponse<RestAppSetNickNameWithQualificationResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置审核 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("examine_id")]
                [System.Text.Json.Serialization.JsonPropertyName("examine_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ExamineId { get; set; }
            }
        }
    }
}
