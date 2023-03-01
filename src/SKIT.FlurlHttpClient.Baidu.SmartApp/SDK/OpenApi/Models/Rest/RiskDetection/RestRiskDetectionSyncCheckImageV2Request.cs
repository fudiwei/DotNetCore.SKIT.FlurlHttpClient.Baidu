using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/riskDetection/v2/syncCheckImage 接口的请求。</para>
    /// </summary>
    public class RestRiskDetectionSyncCheckImageV2Request : BaiduSmartAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置图片文件字节数据。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] ImageFileBytes { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// 获取或设置检测类型列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string>? TypeList { get; set; }
    }
}
