using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Baidu.Push
{
    public static class BaiduPushClientExecuteTagExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /app/query_tags 接口。</para>
        /// <para>REF: https://push.baidu.com/doc/restapi/restapi </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppQueryTagsResponse> ExecuteAppQueryTagsAsync(this BaiduPushClient client, Models.AppQueryTagsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "app", "query_tags");

            if (request.TagName != null)
                flurlReq.SetQueryParam("tag", request.TagName);

            if (request.Start != null)
                flurlReq.SetQueryParam("start", request.Start.Value);

            if (request.Limit != null)
                flurlReq.SetQueryParam("limit", request.Limit.Value);

            return await client.SendRequestWithFormUrlEncodedAsync<Models.AppQueryTagsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /app/create_tag 接口。</para>
        /// <para>REF: https://push.baidu.com/doc/restapi/restapi </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppCreateTagResponse> ExecuteAppCreateTagAsync(this BaiduPushClient client, Models.AppCreateTagRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "app", "create_tag");

            return await client.SendRequestWithFormUrlEncodedAsync<Models.AppCreateTagResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /app/del_tag 接口。</para>
        /// <para>REF: https://push.baidu.com/doc/restapi/restapi </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AppDeleteTagResponse> ExecuteAppDeleteTagAsync(this BaiduPushClient client, Models.AppDeleteTagRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "app", "del_tag");

            return await client.SendRequestWithFormUrlEncodedAsync<Models.AppDeleteTagResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tag/add_devices 接口。</para>
        /// <para>REF: https://push.baidu.com/doc/restapi/restapi </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TagAddDevicesResponse> ExecuteTagAddDevicesAsync(this BaiduPushClient client, Models.TagAddDevicesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tag", "add_devices");

            return await client.SendRequestWithFormUrlEncodedAsync<Models.TagAddDevicesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tag/del_devices 接口。</para>
        /// <para>REF: https://push.baidu.com/doc/restapi/restapi </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TagDeleteDevicesResponse> ExecuteTagDeleteDevicesAsync(this BaiduPushClient client, Models.TagDeleteDevicesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tag", "del_devices");

            return await client.SendRequestWithFormUrlEncodedAsync<Models.TagDeleteDevicesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tag/device_num 接口。</para>
        /// <para>REF: https://push.baidu.com/doc/restapi/restapi </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TagDeviceNumberResponse> ExecuteTagDeviceNumberAsync(this BaiduPushClient client, Models.TagDeviceNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tag", "device_num");

            return await client.SendRequestWithFormUrlEncodedAsync<Models.TagDeviceNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
