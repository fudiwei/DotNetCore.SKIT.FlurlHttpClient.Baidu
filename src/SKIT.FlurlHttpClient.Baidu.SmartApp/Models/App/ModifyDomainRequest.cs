using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.App
{
    public class ModifyDomainRequest : SmartAppRequest
    {
        public string Action { get; set; }

        public string DownloadDomain { get; set; }

        public string RequestDomain { get; set; }

        public string SocketDomain { get; set; }

        public string UploadDomain { get; set; }
    }
}
