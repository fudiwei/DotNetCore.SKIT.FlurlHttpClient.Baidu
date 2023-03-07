using System;

namespace SKIT.FlurlHttpClient.Baidu.Translate.Exceptions
{
    public class BaiduTranslateRequestTimeoutException : BaiduTranslateException
    {
        /// <inheritdoc/>
        internal BaiduTranslateRequestTimeoutException()
        {
        }

        /// <inheritdoc/>
        internal BaiduTranslateRequestTimeoutException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal BaiduTranslateRequestTimeoutException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
