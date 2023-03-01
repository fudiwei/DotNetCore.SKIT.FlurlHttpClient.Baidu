using System;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/robots/template/upload 接口的请求。</para>
    /// </summary>
    public class RestRobotsTemplateUploadRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置模版 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long TemplateId { get; set; }

        /// <summary>
        /// 获取或设置 robots.txt 文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] RobotsFileBytes { get; set; } = Array.Empty<byte>();
    }
}
