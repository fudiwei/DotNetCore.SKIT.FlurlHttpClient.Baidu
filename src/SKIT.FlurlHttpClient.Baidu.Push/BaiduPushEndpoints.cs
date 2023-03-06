namespace SKIT.FlurlHttpClient.Baidu.Push
{
    /// <summary>
    /// 百度云推送 API 接口域名。
    /// </summary>
    public class BaiduPushEndpoints
    {
        /// <summary>
        /// 主域名（默认）。
        /// </summary>
        public const string DEFAULT = "https://api.tuisong.baidu.com/rest/3.0";

        /// <summary>
        /// 备用域名 1。
        /// </summary>
        public const string BACKUP_1 = "https://api.push.baidu.com/rest/3.0";

        /// <summary>
        /// 备用域名 2。
        /// </summary>
        public const string BACKUP_2 = "https://channel.api.duapp.com/rest/3.0";
    }
}
