using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.App
{
    public class QrCodeRequest : SmartAppRequest
    {
        public string Path { get; set; }

        public string PackageId { get; set; }

        public int? Width { get; set; }

    }
}
