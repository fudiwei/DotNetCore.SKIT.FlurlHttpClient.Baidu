namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/template/templatelist 接口的请求。</para>
    /// </summary>
    public class RestTemplateListRequest : BaiduSmartAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int PageOffset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：20</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int PageSize { get; set; } = 20;
    }
}
