using System;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Exceptions
{
    public class BaiduSmartAppRequestTimeoutException : BaiduSmartAppException
    {
        /// <inheritdoc/>
        internal BaiduSmartAppRequestTimeoutException()
        {
        }

        /// <inheritdoc/>
        internal BaiduSmartAppRequestTimeoutException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal BaiduSmartAppRequestTimeoutException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
