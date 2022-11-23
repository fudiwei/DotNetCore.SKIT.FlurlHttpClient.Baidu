using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp
{
    public class SmartAppException : CommonExceptionBase
    {
        public SmartAppException()
        {
        }

        public SmartAppException(string message)
            : base(message)
        {
        }

        public SmartAppException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
