using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.Auth
{
    public class RetrieveAuthorizationCodeRequest : SmartAppRequest
    {
        /// <summary>
        /// 授权小程序appId
        /// </summary>
        public string AuthorizeAppId { get; set; }
    }
}
