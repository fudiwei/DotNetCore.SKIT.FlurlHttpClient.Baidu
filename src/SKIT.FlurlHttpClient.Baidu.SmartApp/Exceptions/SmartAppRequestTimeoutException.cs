using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Exceptions
{
    public class SmartAppRequestTimeoutException : SmartAppException
    {
        internal SmartAppRequestTimeoutException()
        {
        }

        internal SmartAppRequestTimeoutException(string message)
            : base(message)
        {
        }

        internal SmartAppRequestTimeoutException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
