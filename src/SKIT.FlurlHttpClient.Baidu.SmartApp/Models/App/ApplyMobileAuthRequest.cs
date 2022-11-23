using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.App
{
    public class ApplyMobileAuthRequest : SmartAppRequest
    {
        public int Reason { get; set; }

        public int UsedScene { get; set; }

        public string SceneDesc { get; set; }

        public string SceneDemo { get; set; }
    }
}
