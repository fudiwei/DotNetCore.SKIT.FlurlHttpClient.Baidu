namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/app/modifydomain 接口的响应。</para>
    /// </summary>
    public class RestAppModifyDomainResponse : BaiduSmartAppThirdPartyResponse<RestAppModifyDomainResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置请求合法域名列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("request_domain")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringArrayWithCommaSplitConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("request_domain")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringArrayWithCommaSplitConverter))]
                public string[]? RequestDomainList { get; set; }

                /// <summary>
                /// 获取或设置上传合法域名列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("upload_domain")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringArrayWithCommaSplitConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("upload_domain")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringArrayWithCommaSplitConverter))]
                public string[]? UploadDomainList { get; set; }

                /// <summary>
                /// 获取或设置下载合法域名列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("download_domain")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringArrayWithCommaSplitConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("download_domain")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringArrayWithCommaSplitConverter))]
                public string[]? DownloadDomainList { get; set; }

                /// <summary>
                /// 获取或设置 Socket 合法域名列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("socket_domain")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringArrayWithCommaSplitConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("socket_domain")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringArrayWithCommaSplitConverter))]
                public string[]? SocketDomainList { get; set; }
            }
        }
    }
}
