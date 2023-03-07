using System;

namespace SKIT.FlurlHttpClient.Baidu.Translate
{
    /// <summary>
    /// 当调用百度翻译开放平台 API 出错时引发的异常。
    /// </summary>
    public class BaiduTranslateException : CommonExceptionBase
    {
        /// <inheritdoc/>
        public BaiduTranslateException()
        {
        }

        /// <inheritdoc/>
        public BaiduTranslateException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        public BaiduTranslateException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
