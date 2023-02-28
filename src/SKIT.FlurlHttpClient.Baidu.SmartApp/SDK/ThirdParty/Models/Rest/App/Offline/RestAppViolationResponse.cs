namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/app/violation 接口的响应。</para>
    /// </summary>
    public class RestAppViolationResponse : BaiduSmartAppThirdPartyResponse<RestAppViolationResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ProblemDetail
                    {
                        /// <summary>
                        /// 获取或设置任务 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("taskId")]
                        [System.Text.Json.Serialization.JsonPropertyName("taskId")]
                        public long TaskId { get; set; }

                        /// <summary>
                        /// 获取或设置问题状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置问题描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("problemDesc")]
                        [System.Text.Json.Serialization.JsonPropertyName("problemDesc")]
                        public string ProblemDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置问题路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("problemPath")]
                        [System.Text.Json.Serialization.JsonPropertyName("problemPath")]
                        public string ProblemPath { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置截图 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("screenShot")]
                        [Newtonsoft.Json.JsonConverter(typeof(Converters.ResponsePropertyProblemDetailScreenshotUrlListNewtonsoftJsonConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("screenShot")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.ResponsePropertyProblemDetailScreenshotUrlListSystemTextJsonConverter))]
                        public string[] ScreenshotUrlList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置审核原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("auditReason")]
                        [System.Text.Json.Serialization.JsonPropertyName("auditReason")]
                        public string? AuditReason { get; set; }

                        /// <summary>
                        /// 获取或设置审核截图 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("auditShot")]
                        [Newtonsoft.Json.JsonConverter(typeof(Converters.ResponsePropertyProblemDetailScreenshotUrlListNewtonsoftJsonConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("auditShot")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.ResponsePropertyProblemDetailScreenshotUrlListSystemTextJsonConverter))]
                        public string[]? AuditScreenshotUrlList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appId")]
                [System.Text.Json.Serialization.JsonPropertyName("appId")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置问题列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("problemDetails")]
                [System.Text.Json.Serialization.JsonPropertyName("problemDetails")]
                public Types.ProblemDetail[] ProblemDetailList { get; set; } = default!;
            }
        }

        internal static class Converters
        {
            internal class ResponsePropertyProblemDetailScreenshotUrlListNewtonsoftJsonConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<string[]?>
            {
            }

            internal class ResponsePropertyProblemDetailScreenshotUrlListSystemTextJsonConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<string[]?>
            {
            }
        }
    }
}
