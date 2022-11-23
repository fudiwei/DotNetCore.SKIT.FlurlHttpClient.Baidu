using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.Template
{
    public class GetTemplateDraftListRequest : SmartAppRequest
    {
        public int? Page { get; set; }

        public int? PageSize { get; set; }
    }
}
