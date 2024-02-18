using System;

namespace SKIT.FlurlHttpClient.Baidu.Push
{
    /// <summary>
    /// 当调用百度云推送 API 出错时引发的异常。
    /// </summary>
    public class BaiduPushException : CommonException
    {
        /// <inheritdoc/>
        public BaiduPushException()
        {
        }

        /// <inheritdoc/>
        public BaiduPushException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        public BaiduPushException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
