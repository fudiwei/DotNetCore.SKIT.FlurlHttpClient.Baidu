using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.App
{
    public class UploadImageRequest : SmartAppRequest
    {
        public string FilePath { get; set; }

        public int Type { get; set; }
    }
}
