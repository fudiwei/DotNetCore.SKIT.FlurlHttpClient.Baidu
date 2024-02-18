using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Baidu.Push
{
    public static class BaiduPushClientExecuteReportExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /report/query_msg_status 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://push.baidu.com/doc/restapi/restapi ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReportQueryMessageStatusResponse> ExecuteReportQueryMessageStatusAsync(this BaiduPushClient client, Models.ReportQueryMessageStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "report", "query_msg_status")
                .SetQueryParam("msg_id", client.JsonSerializer.Serialize(request.MessageIdList));

            return await client.SendRequestAsFormUrlEncodedAsync<Models.ReportQueryMessageStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /report/query_timer_records 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://push.baidu.com/doc/restapi/restapi ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReportQueryTimerRecordsResponse> ExecuteReportQueryTimerRecordsAsync(this BaiduPushClient client, Models.ReportQueryTimerRecordsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "report", "query_timer_records")
                .SetQueryParam("timer_id", request.TimerId);

            if (request.Start is not null)
                flurlReq.SetQueryParam("start", request.Start.Value);

            if (request.Limit is not null)
                flurlReq.SetQueryParam("limit", request.Limit.Value);

            if (request.StartTimestamp is not null)
                flurlReq.SetQueryParam("range_start", request.StartTimestamp.Value);

            if (request.EndTimestamp is not null)
                flurlReq.SetQueryParam("range_end", request.EndTimestamp.Value);

            return await client.SendRequestAsFormUrlEncodedAsync<Models.ReportQueryTimerRecordsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /report/query_topic_records 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://push.baidu.com/doc/restapi/restapi ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReportQueryTopicRecordsResponse> ExecuteReportQueryTopicRecordsAsync(this BaiduPushClient client, Models.ReportQueryTopicRecordsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "report", "query_topic_records")
                .SetQueryParam("topic_id", request.TopicId);

            if (request.Start is not null)
                flurlReq.SetQueryParam("start", request.Start.Value);

            if (request.Limit is not null)
                flurlReq.SetQueryParam("limit", request.Limit.Value);

            if (request.StartTimestamp is not null)
                flurlReq.SetQueryParam("range_start", request.StartTimestamp.Value);

            if (request.EndTimestamp is not null)
                flurlReq.SetQueryParam("range_end", request.EndTimestamp.Value);

            return await client.SendRequestAsFormUrlEncodedAsync<Models.ReportQueryTopicRecordsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /report/statistic_device 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://push.baidu.com/doc/restapi/restapi ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReportStatisticDeviceResponse> ExecuteReportStatisticDeviceAsync(this BaiduPushClient client, Models.ReportStatisticDeviceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "report", "statistic_device");

            return await client.SendRequestAsFormUrlEncodedAsync<Models.ReportStatisticDeviceResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /report/statistic_topic 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://push.baidu.com/doc/restapi/restapi ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReportStatisticTopicResponse> ExecuteReportStatisticTopicAsync(this BaiduPushClient client, Models.ReportStatisticTopicRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "report", "statistic_topic")
                .SetQueryParam("topic_id", request.TopicId);

            return await client.SendRequestAsFormUrlEncodedAsync<Models.ReportStatisticTopicResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
