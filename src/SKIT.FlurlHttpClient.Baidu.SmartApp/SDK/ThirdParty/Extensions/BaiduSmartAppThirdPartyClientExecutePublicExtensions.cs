using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty
{
    public static class BaiduSmartAppThirdPartyClientExecutePublicExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /public/2.0/smartapp/auth/tp/token 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/auth/access_token/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PublicAuthThirdPartyTokenResponse> ExecutePublicAuthThirdPartyTokenAsync(this BaiduSmartAppThirdPartyClient client, Models.PublicAuthThirdPartyTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "public", "2.0", "smartapp", "auth", "tp", "token")
                .SetQueryParam("client_id", client.Credentials.AppKey)
                .SetQueryParam("ticket", request.Ticket);

            return await client.SendRequestWithJsonAsync<Models.PublicAuthThirdPartyTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
