namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/pay/paymentservice/auditstatus 接口的响应。</para>
    /// </summary>
    public class RestPayPaymentServiceAuditStatusResponse : BaiduSmartAppThirdPartyResponse<RestPayPaymentServiceAuditStatusResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置审核状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置验证信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("verify_message")]
                [System.Text.Json.Serialization.JsonPropertyName("verify_message")]
                public string? VerifyMessage { get; set; }
            }
        }
    }
}
