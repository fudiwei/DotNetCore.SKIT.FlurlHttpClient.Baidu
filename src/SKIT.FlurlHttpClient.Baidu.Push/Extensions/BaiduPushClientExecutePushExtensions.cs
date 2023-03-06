using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Baidu.Push
{
    public static class BaiduPushClientExecutePushExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /push/single_device 接口。</para>
        /// <para>REF: https://push.baidu.com/doc/restapi/restapi </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PushSingleDeviceResponse> ExecutePushSingleDeviceAsync(this BaiduPushClient client, Models.PushSingleDeviceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "push", "single_device");

            return await client.SendRequestWithFormUrlEncodedAsync<Models.PushSingleDeviceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /push/all 接口。</para>
        /// <para>REF: https://push.baidu.com/doc/restapi/restapi </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PushAllResponse> ExecutePushAllAsync(this BaiduPushClient client, Models.PushAllRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "push", "all");

            return await client.SendRequestWithFormUrlEncodedAsync<Models.PushAllResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /push/tags 接口。</para>
        /// <para>REF: https://push.baidu.com/doc/restapi/restapi </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PushTagsResponse> ExecutePushTagsAsync(this BaiduPushClient client, Models.PushTagsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "push", "tags");

            return await client.SendRequestWithFormUrlEncodedAsync<Models.PushTagsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /push/batch_device 接口。</para>
        /// <para>REF: https://push.baidu.com/doc/restapi/restapi </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PushBatchDeviceResponse> ExecutePushBatchDeviceAsync(this BaiduPushClient client, Models.PushBatchDeviceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "push", "batch_device");

            return await client.SendRequestWithFormUrlEncodedAsync<Models.PushBatchDeviceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
