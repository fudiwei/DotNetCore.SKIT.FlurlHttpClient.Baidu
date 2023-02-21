using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/app/checknamewithqual 接口的请求。</para>
    /// </summary>
    public class RestAppCheckNameWithQualificationRequest : BaiduSmartAppThirdPartyRequest
    {
        public static class Types
        {
            public class QualificationMaterial : RestAppSetNickNameWithQualificationRequest.Types.QualificationMaterial
            {
            }
        }

        /// <summary>
        /// 获取或设置小程序名称。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string AppName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置资质证明材料信息。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public Types.QualificationMaterial? QualificationMaterial { get; set; }
    }
}
