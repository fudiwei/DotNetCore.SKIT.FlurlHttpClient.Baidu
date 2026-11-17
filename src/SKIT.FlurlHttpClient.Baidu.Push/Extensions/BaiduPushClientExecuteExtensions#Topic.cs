namespace SKIT.FlurlHttpClient.Baidu.Push
{
    public static partial class BaiduPushClientExecuteExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /topic/query_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://push.baidu.com/doc/restapi/restapi ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TopicQueryListResponse> ExecuteTopicQueryListAsync(this BaiduPushClient client, Models.TopicQueryListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "topic", "query_list")
                .SetQueryParam("start", request.Start)
                .SetQueryParam("limit", request.Limit);

            return await client.SendRequestAsFormUrlEncodedAsync<Models.TopicQueryListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
