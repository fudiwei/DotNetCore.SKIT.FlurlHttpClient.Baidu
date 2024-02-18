using System;
using Flurl;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty
{
    public static class BaiduSmartAppThirdPartyClientParameterExtensions
    {
        /// <summary>
        /// <para>生成第三方平台进行授权 URL。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://smartprogram.baidu.com/docs/third/auth/guide ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="preAuthCode"></param>
        /// <param name="redirectUrl"></param>
        /// <returns></returns>
        public static string GenerateParameterizedUrlForThirdPartyAuth(this BaiduSmartAppThirdPartyClient client, string preAuthCode, string redirectUrl)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            return new Url("https://smartprogram.baidu.com/developer/tpservice.html")
                .SetQueryParam("client_id", client.Credentials.AppKey)
                .SetQueryParam("pre_auth_code", preAuthCode)
                .SetQueryParam("redirect_uri", redirectUrl)
                .ToString();
        }
    }
}
