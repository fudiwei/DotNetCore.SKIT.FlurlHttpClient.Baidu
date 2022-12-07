using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.App
{
    public class SetNickNameWithQualRequest : SmartAppRequest
    {
        public string NickName { get; set; }

        public string QualMaterials { get; set; }
    }
}
