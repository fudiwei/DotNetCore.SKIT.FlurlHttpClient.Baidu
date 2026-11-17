namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/tp/modifydomain 接口的响应。</para>
    /// </summary>
    public class RestThirdPartyModifyDomainResponse : BaiduSmartAppThirdPartyResponse<RestThirdPartyModifyDomainResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置请求合法域名列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("request_domain")]
                [System.Text.Json.Serialization.JsonPropertyName("request_domain")]
                public List<string>? RequestDomainList { get; set; }

                /// <summary>
                /// 获取或设置上传合法域名列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("upload_domain")]
                [System.Text.Json.Serialization.JsonPropertyName("upload_domain")]
                public List<string>? UploadDomainList { get; set; }

                /// <summary>
                /// 获取或设置下载合法域名列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("download_domain")]
                [System.Text.Json.Serialization.JsonPropertyName("download_domain")]
                public List<string>? DownloadDomainList { get; set; }

                /// <summary>
                /// 获取或设置 Socket 合法域名列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("socket_domain")]
                [System.Text.Json.Serialization.JsonPropertyName("socket_domain")]
                public List<string>? SocketDomainList { get; set; }
            }
        }
    }
}
