using System;

namespace SKIT.FlurlHttpClient.Baidu.Push.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="BaiduPushClientOptions.ApiKey"/> 的副本。
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// 初始化客户端时 <see cref="BaiduPushClientOptions.SecretKey"/> 的副本。
        /// </summary>
        public string SecretKey { get; set; }

        internal Credentials(BaiduPushClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            ApiKey = options.ApiKey;
            SecretKey = options.SecretKey;
        }
    }
}
