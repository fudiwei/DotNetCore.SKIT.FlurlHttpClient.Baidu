using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/prelink/set 接口的响应。</para>
    /// </summary>
    public class RestPrelinkSetResponse : BaiduSmartAppThirdPartyResponse<RestPrelinkSetResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class CheckResult
                    {
                        /// <summary>
                        /// 获取或设置状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置失败原因列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("failReason")]
                        [System.Text.Json.Serialization.JsonPropertyName("failReason")]
                        public string[]? FailReasonList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置检查结果字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("checkResult")]
                [System.Text.Json.Serialization.JsonPropertyName("checkResult")]
                public IDictionary<string, Types.CheckResult> CheckResultMap { get; set; } = default!;
            }
        }
    }
}
