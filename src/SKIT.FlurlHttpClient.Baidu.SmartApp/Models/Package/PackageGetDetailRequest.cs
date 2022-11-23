using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.Package
{
    public class PackageGetDetailRequest : SmartAppRequest
    {
        public int? Type { get; set; }

        public int? PackageId { get; set; }
    }
}
