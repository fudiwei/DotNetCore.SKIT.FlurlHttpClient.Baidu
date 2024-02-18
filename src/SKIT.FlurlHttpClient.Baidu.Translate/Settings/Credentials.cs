using System;

namespace SKIT.FlurlHttpClient.Baidu.Translate.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="BaiduTranslateClientOptions.AppId"/> 的副本。
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 初始化客户端时 <see cref="BaiduTranslateClientOptions.AppSecret"/> 的副本。
        /// </summary>
        public string AppSecret { get; set; }

        internal Credentials(BaiduTranslateClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            AppId = options.AppId;
            AppSecret = options.AppSecret;
        }
    }
}
