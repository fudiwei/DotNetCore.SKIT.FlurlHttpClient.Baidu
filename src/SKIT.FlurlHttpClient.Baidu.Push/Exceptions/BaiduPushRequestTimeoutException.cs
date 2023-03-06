using System;

namespace SKIT.FlurlHttpClient.Baidu.Push.Exceptions
{
    public class BaiduPushRequestTimeoutException : BaiduPushException
    {
        /// <inheritdoc/>
        internal BaiduPushRequestTimeoutException()
        {
        }

        /// <inheritdoc/>
        internal BaiduPushRequestTimeoutException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal BaiduPushRequestTimeoutException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
