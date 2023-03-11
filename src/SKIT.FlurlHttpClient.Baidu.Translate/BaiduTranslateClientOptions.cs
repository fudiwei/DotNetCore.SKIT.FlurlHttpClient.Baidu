namespace SKIT.FlurlHttpClient.Baidu.Translate
{
    /// <summary>
    /// 一个用于构造 <see cref="BaiduTranslateClient"/> 时使用的配置项。
    /// </summary>
    public class BaiduTranslateClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置百度翻译开放平台 API 入口点。
        /// <para>默认值：<see cref="BaiduTranslateEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoint { get; set; } = BaiduTranslateEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置百度翻译 AppId。
        /// </summary>
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置百度翻译 AppSecret。
        /// </summary>
        public string AppSecret { get; set; } = default!;
    }
}
