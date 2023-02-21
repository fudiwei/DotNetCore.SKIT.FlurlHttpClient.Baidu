using System;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Exceptions
{
    public class BaiduSmartAppEventSerializationException : BaiduSmartAppException
    {
        /// <inheritdoc/>
        internal BaiduSmartAppEventSerializationException()
        {
        }

        /// <inheritdoc/>
        internal BaiduSmartAppEventSerializationException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal BaiduSmartAppEventSerializationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
