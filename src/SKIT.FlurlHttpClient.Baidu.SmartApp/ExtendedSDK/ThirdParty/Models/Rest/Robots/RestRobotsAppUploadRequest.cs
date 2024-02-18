using System;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/robots/app/upload 接口的请求。</para>
    /// </summary>
    public class RestRobotsAppUploadRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置 robots.txt 文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] RobotsFileBytes { get; set; } = Array.Empty<byte>();
    }
}
