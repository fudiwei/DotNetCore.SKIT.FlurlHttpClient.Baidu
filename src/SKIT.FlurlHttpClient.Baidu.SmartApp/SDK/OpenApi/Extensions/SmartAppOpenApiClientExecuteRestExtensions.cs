using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi
{
    public static class SmartAppOpenApiClientExecuteRestExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/getsessionkey 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/api/open/getSessionKey/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestGetSessionKeyResponse> ExecuteRestGetSessionKeyAsync(this BaiduSmartAppOpenApiClient client, Models.RestGetSessionKeyRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "getsessionkey")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("grant_type", request.GrantType)
                .SetQueryParam("code", request.Code);

            return await client.SendRequestWithJsonAsync<Models.RestGetSessionKeyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/getunionid 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/api/open/getSessionKey/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestGetUnionIdResponse> ExecuteRestGetUnionIdAsync(this BaiduSmartAppOpenApiClient client, Models.RestGetUnionIdRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "getunionid")
                .SetQueryParam("access_token", request.AccessToken);

            using var httpContent = new FormUrlEncodedContent(new Dictionary<string, string>()
            {
                { "openid", request.OpenId }
            });
            return await client.SendRequestAsync<Models.RestGetUnionIdResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }
    }
}
