using System;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp
{
    /// <summary>
    /// 当调用百度智能小程序 API 出错时引发的异常。
    /// </summary>
    public class BaiduSmartAppException : CommonExceptionBase
    {
        /// <inheritdoc/>
        public BaiduSmartAppException()
        {
        }

        /// <inheritdoc/>
        public BaiduSmartAppException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        public BaiduSmartAppException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
