using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Exceptions
{
    public class SmartAppEventSerializationException : SmartAppException
    {
        internal SmartAppEventSerializationException()
        {
        }

        internal SmartAppEventSerializationException(string message)
            : base(message)
        {
        }

        internal SmartAppEventSerializationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
