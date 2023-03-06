using System;

namespace SKIT.FlurlHttpClient.Baidu.Push.Exceptions
{
    public class BaiduPushRequestSignatureException : BaiduPushException
    {
        /// <inheritdoc/>
        internal BaiduPushRequestSignatureException()
        {
        }

        /// <inheritdoc/>
        internal BaiduPushRequestSignatureException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal BaiduPushRequestSignatureException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
