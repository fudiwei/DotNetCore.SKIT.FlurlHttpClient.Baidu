using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/access/submit/sitemap 接口的请求。</para>
    /// </summary>
    public class RestAccessSubmitSitemapRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置上传级别。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int UploadType { get; set; }

        /// <summary>
        /// 获取或设置 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url_list")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("url_list")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringListWithCommaSplitConverter))]
        public IList<string> UrlList { get; set; } = new List<string>();
    }
}
