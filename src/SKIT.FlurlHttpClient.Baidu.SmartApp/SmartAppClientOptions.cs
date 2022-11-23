using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp
{
    /// <summary>
    /// 一个用于构造 <see cref="SmartAppThirdPartyClient"/> 时使用的配置项。
    /// </summary>
    public class SmartAppClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置百度 API 域名。
        /// <para>默认值：<see cref="SmartAppEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoints { get; set; } = SmartAppEndpoints.DEFAULT;

        /// <summary>
        /// 第三方平台ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 第三方平台Key
        /// </summary>
        public string AppKey { get; set; }

        /// <summary>
        /// 密钥
        /// </summary>
        public string AppSecret { get; set; }

        /// <summary>
        /// 消息验证TOKEN
        /// </summary>
        public string VerifyToken { get; set; }

        /// <summary>
        /// 消息加解密Key
        /// </summary>
        public string EncryptKey { get; set; }
    }
}
