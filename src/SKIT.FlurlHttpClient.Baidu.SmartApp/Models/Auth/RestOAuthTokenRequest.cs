using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.Auth
{
    public class RestOAuthTokenRequest : SmartAppRequest
    {
        /// <summary>
        /// 授权码(使用授权码换小程序的接口调用凭据和授权信息必传)
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 接口调用凭据刷新令牌(刷新授权小程序的接口调用凭据必传)
        /// </summary>
        public string RefreshToken { get; set; }

        /// <summary>
        /// 固定字符串
        /// 使用授权码换小程序的接口调用凭据:app_to_tp_authorization_code
        /// 刷新授权小程序的接口调用凭据:app_to_tp_refresh_token
        /// </summary>
        public string GrantType { get; set; }
    }
}
