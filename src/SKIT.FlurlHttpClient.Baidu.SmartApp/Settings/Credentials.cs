using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Settings
{
    public class Credentials
    {
        internal Credentials(SmartAppClientOptions options)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            this.AppId = options.AppId;
            this.AppKey = options.AppKey;
            this.AppSecret = options.AppSecret;
            this.VerifyToken = options.VerifyToken;
            this.EncryptKey = options.EncryptKey;
        }

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
