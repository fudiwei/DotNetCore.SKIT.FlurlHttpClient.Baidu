using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Events
{
    /// <summary>
    /// 真实性认证结果推送事件
    /// <para> REF: https://smartprogram.baidu.com/docs/third/advanced_auth/advanced_auth_push </para>
    /// </summary>
    public class AdvancedAuditChangedEvent : SmartAppEvent
    {
        /// <summary>
        /// 认证类型
        /// -1：其他类型验证 0：未做真实性认证 1：对公验证 2：活体验证 23：法人人脸验证
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adType")]
        [System.Text.Json.Serialization.JsonPropertyName("adType")]
        public int AdType { get; set; }

        /// <summary>
        /// 认证状态
        /// 1:真实性认证通过 7:对公打款认证: 对公打款认证完成,待支付认证费用法人人脸识别认证: 人脸识别认证完成,待支付认证费用
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adStatus")]
        [System.Text.Json.Serialization.JsonPropertyName("adStatus")]
        public int AdStatus { get; set; }
    }
}
