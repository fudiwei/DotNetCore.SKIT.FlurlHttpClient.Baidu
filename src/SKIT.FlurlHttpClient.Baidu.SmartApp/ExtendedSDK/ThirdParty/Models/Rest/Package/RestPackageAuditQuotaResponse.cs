namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/package/auditquota 接口的响应。</para>
    /// </summary>
    public class RestPackageAuditQuotaResponse : BaiduSmartAppThirdPartyResponse<RestPackageAuditQuotaResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置额度限制。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quota_type")]
                [System.Text.Json.Serialization.JsonPropertyName("quota_type")]
                public int QuotaType { get; set; }

                /// <summary>
                /// 获取或设置单个周期内额度上限。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quota_times")]
                [System.Text.Json.Serialization.JsonPropertyName("quota_times")]
                public int QuotaTimes { get; set; }

                /// <summary>
                /// 获取或设置当前周期内剩余额度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remain_times")]
                [System.Text.Json.Serialization.JsonPropertyName("remain_times")]
                public int RemainingTimes { get; set; }
            }
        }
    }
}
