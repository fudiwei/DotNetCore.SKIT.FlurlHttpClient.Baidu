using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Baidu.Push
{
    public static class BaiduPushClientExecuteTimerExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /timer/query_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://push.baidu.com/doc/restapi/restapi ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TimerQueryListResponse> ExecuteTimerQueryListAsync(this BaiduPushClient client, Models.TimerQueryListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "timer", "query_list");

            if (request.TimerId is not null)
                flurlReq.SetQueryParam("timer_id", request.TimerId);

            if (request.Start is not null)
                flurlReq.SetQueryParam("start", request.Start.Value);

            if (request.Limit is not null)
                flurlReq.SetQueryParam("limit", request.Limit.Value);

            return await client.SendRequestAsFormUrlEncodedAsync<Models.TimerQueryListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /timer/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://push.baidu.com/doc/restapi/restapi ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TimerCancelResponse> ExecuteTimerCancelAsync(this BaiduPushClient client, Models.TimerCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "timer", "cancel");

            return await client.SendRequestAsFormUrlEncodedAsync<Models.TimerCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
