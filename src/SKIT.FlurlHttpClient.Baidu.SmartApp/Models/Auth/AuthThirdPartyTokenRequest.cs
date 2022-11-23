using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.Auth
{
    public class AuthThirdPartyTokenRequest : SmartAppRequest
    {
        public string ClientId { get; set; }

        public string Ticket { get; set; }
    }
}
