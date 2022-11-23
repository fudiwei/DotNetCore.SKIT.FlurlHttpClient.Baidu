using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.Template
{
    public class AddToTemplateRequest : SmartAppRequest
    {
        public string DraftId { get; set; }

        public string UserDesc { get; set; }
    }
}
