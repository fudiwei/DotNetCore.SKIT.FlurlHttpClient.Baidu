using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/app/category/list 接口的请求。</para>
    /// </summary>
    public class RestAppCategoryListRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置类目类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int CategoryType { get; set; }
    }
}
