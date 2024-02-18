using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/app/modifydomain 接口的请求。</para>
    /// </summary>
    public class RestAppModifyDomainRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置操作类型。
        /// <para>默认值：get</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = "get";

        /// <summary>
        /// 获取或设置请求合法域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_domain")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedStringListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("request_domain")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedStringListWithCommaSplitConverter))]
        public IList<string>? RequestDomainList { get; set; }

        /// <summary>
        /// 获取或设置上传合法域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upload_domain")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedStringListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("upload_domain")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedStringListWithCommaSplitConverter))]
        public IList<string>? UploadDomainList { get; set; }

        /// <summary>
        /// 获取或设置下载合法域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("download_domain")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedStringListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("download_domain")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedStringListWithCommaSplitConverter))]
        public IList<string>? DownloadDomainList { get; set; }

        /// <summary>
        /// 获取或设置 Socket 合法域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("socket_domain")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedStringListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("socket_domain")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedStringListWithCommaSplitConverter))]
        public IList<string>? SocketDomainList { get; set; }
    }
}
