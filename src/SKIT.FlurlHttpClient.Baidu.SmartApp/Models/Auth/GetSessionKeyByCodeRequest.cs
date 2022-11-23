using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.Auth
{
    public class GetSessionKeyByCodeRequest : SmartAppRequest
    {
        /// <summary>
        /// 调用 swan.getLoginCode 后获取的 code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 授权类型，固定字符串：“authorization_code”
        /// </summary>
        public string GrantType { get; set; } = "authorization_code";
    }
}
