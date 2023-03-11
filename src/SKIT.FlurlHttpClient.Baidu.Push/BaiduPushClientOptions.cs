using System.Reflection;
using System;

namespace SKIT.FlurlHttpClient.Baidu.Push
{
    /// <summary>
    /// 一个用于构造 <see cref="BaiduPushClient"/> 时使用的配置项。
    /// </summary>
    public class BaiduPushClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置百度云推送 API 入口点。
        /// <para>默认值：<see cref="BaiduPushEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoint { get; set; } = BaiduPushEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置客户端用户代理。
        /// <para>默认值：<i>根据操作系统自动生成</i></para>
        /// </summary>
        public string UserAgent { get; set; } = $"BCCS_SDK/3.0 ({Environment.OSVersion.Platform}; {Environment.OSVersion.VersionString}) .NET/{Environment.Version} (SKIT.FlurlHttpClient.Baidu.Push v{Assembly.GetExecutingAssembly().GetName().Version}) cli/Unknown";

        /// <summary>
        /// 获取或设置百度云推送 API Key。
        /// </summary>
        public string ApiKey { get; set; } = default!;

        /// <summary>
        /// 获取或设置百度云推送 Secret Key。
        /// </summary>
        public string SecretKey { get; set; } = default!;
    }
}
