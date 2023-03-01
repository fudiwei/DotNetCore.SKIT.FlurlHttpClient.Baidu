using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi
{
    public static class BaiduSmartAppOpenApiClientExecuteOAuthExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /oauth/2.0/token 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/power_exp/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OAuthTokenResponse> ExecuteOAuthTokenAsync(this BaiduSmartAppOpenApiClient client, Models.OAuthTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "oauth", "2.0", "token")
                .SetQueryParam("grant_type", request.GrantType)
                .SetQueryParam("client_id", client.Credentials.AppKey)
                .SetQueryParam("client_secret", client.Credentials.AppSecret)
                .SetQueryParam("scope", request.Scope);

            return await client.SendRequestWithJsonAsync<Models.OAuthTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
