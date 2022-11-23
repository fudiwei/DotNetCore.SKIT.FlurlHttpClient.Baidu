using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Events
{
    /// <summary>
    /// 手机号权限审核失败
    /// <para> REF:https://smartprogram.baidu.com/docs/third/phone/phone_push </para>
    /// </summary>
    public class ApplyAppMobileAuthRejectEvent : SmartAppEvent
    {
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
