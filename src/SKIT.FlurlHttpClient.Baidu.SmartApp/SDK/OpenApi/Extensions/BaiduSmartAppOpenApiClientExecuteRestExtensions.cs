using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi
{
    public static class BaiduSmartAppOpenApiClientExecuteRestExtensions
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
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "getsessionkey")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("grant_type", request.GrantType)
                .SetQueryParam("code", request.Code);

            return await client.SendRequestWithJsonAsync<Models.RestGetSessionKeyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/getunionid 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/api/open/log_getunionid/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestGetUnionIdResponse> ExecuteRestGetUnionIdAsync(this BaiduSmartAppOpenApiClient client, Models.RestGetUnionIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "getunionid")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("openid", request.OpenId);

            return await client.SendRequestWithFormUrlEncodedAsync<Models.RestGetUnionIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Qrcode
        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/qrcode/getv2 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/get_qrcode/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestQrcodeGetV2Response> ExecuteRestQrcodeGetV2Async(this BaiduSmartAppOpenApiClient client, Models.RestQrcodeGetV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "qrcode", "getv2")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithFormUrlEncodedAsync<Models.RestQrcodeGetV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/qrcode/getunlimitedv2 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/get_qrcode/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestQrcodeGetUnlimitedV2Response> ExecuteRestQrcodeGetUnlimitedV2Async(this BaiduSmartAppOpenApiClient client, Models.RestQrcodeGetUnlimitedV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "qrcode", "getunlimitedv2")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithFormUrlEncodedAsync<Models.RestQrcodeGetUnlimitedV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Risk
        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/detectrisk 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/open_risk_power_detectrisk/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestDetectRiskResponse> ExecuteRestDetectRiskAsync(this BaiduSmartAppOpenApiClient client, Models.RestDetectRiskRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppKey == null)
                request.AppKey = client.Credentials.AppKey;

            if (request.Timestamp == null)
                request.Timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds();

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "detectrisk")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithFormUrlEncodedAsync<Models.RestDetectRiskResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region RiskDetection
        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/riskDetection/v2/syncCheckText 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/text_security_detection/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestRiskDetectionSyncCheckTextV2Response> ExecuteRestRiskDetectionSyncCheckTextV2Async(this BaiduSmartAppOpenApiClient client, Models.RestRiskDetectionSyncCheckTextV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "riskDetection", "v2", "syncCheckText")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RestRiskDetectionSyncCheckTextV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/riskDetection/v2/syncCheckImage 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/picture_security_check/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestRiskDetectionSyncCheckImageV2Response> ExecuteRestRiskDetectionSyncCheckImageV2Async(this BaiduSmartAppOpenApiClient client, Models.RestRiskDetectionSyncCheckImageV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "riskDetection", "v2", "syncCheckImage")
                .SetQueryParam("access_token", request.AccessToken);

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: "image.jpg", fileBytes: request.ImageFileBytes, fileContentType: "image/jpeg", formDataName: "image");
            if (request.TypeList != null)
                httpContent.Add(new StringContent(string.Join(",", request.TypeList), Encoding.UTF8), "type");

            return await client.SendRequestAsync<Models.RestRiskDetectionSyncCheckImageV2Response>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/riskDetection/v2/asyncCheckPath 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/content_security_check/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestRiskDetectionAsyncCheckPathV2Response> ExecuteRestRiskDetectionAsyncCheckPathV2Async(this BaiduSmartAppOpenApiClient client, Models.RestRiskDetectionAsyncCheckPathV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "riskDetection", "v2", "asyncCheckPath")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RestRiskDetectionAsyncCheckPathV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/riskDetection/misjudgeFeedback 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/result_misjudgment_feedback/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestRiskDetectionMisjudgeFeedbackResponse> ExecuteRestRiskDetectionMisjudgeFeedbackAsync(this BaiduSmartAppOpenApiClient client, Models.RestRiskDetectionMisjudgeFeedbackRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "riskDetection", "misjudgeFeedback")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithFormUrlEncodedAsync<Models.RestRiskDetectionMisjudgeFeedbackResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region TemplateMessage
        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/template/librarylist 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/getTemplateLibraryList/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestTemplateLibraryListResponse> ExecuteRestTemplateLibraryListAsync(this BaiduSmartAppOpenApiClient client, Models.RestTemplateLibraryListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "template", "librarylist")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("offset", request.PageOffset)
                .SetQueryParam("count", request.PageSize);

            return await client.SendRequestWithJsonAsync<Models.RestTemplateLibraryListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/template/libraryget 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/getTemplateLibraryById/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestTemplateLibraryGetResponse> ExecuteRestTemplateLibraryGetAsync(this BaiduSmartAppOpenApiClient client, Models.RestTemplateLibraryGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "template", "libraryget")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("id", request.Id);

            return await client.SendRequestWithJsonAsync<Models.RestTemplateLibraryGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/template/templatelist 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/getTemplateList/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestTemplateListResponse> ExecuteRestTemplateListAsync(this BaiduSmartAppOpenApiClient client, Models.RestTemplateListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "template", "templatelist")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("offset", request.PageOffset)
                .SetQueryParam("count", request.PageSize);

            return await client.SendRequestWithJsonAsync<Models.RestTemplateListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/template/templateadd 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/addTemplate/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestTemplateAddResponse> ExecuteRestTemplateAddAsync(this BaiduSmartAppOpenApiClient client, Models.RestTemplateAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "template", "templateadd")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("id", request.Id)
                .SetQueryParam("keyword_id_list", client.JsonSerializer.Serialize(request.KeywordIdList));

            return await client.SendRequestWithJsonAsync<Models.RestTemplateAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/template/templatedel 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/deleteTemplate/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestTemplateDeleteResponse> ExecuteRestTemplateDeleteAsync(this BaiduSmartAppOpenApiClient client, Models.RestTemplateDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "template", "templatedel")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("template_id", request.TemplateId);

            return await client.SendRequestWithJsonAsync<Models.RestTemplateDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/template/send 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/sendTemplateMessage/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestTemplateSendResponse> ExecuteRestTemplateSendAsync(this BaiduSmartAppOpenApiClient client, Models.RestTemplateSendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "template", "send")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithFormUrlEncodedAsync<Models.RestTemplateSendResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/template/message/subscribe/send 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/subscribe_msg_send/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestTemplateMessageSubscribeSendResponse> ExecuteRestTemplateMessageSubscribeSendAsync(this BaiduSmartAppOpenApiClient client, Models.RestTemplateMessageSubscribeSendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "template", "message", "subscribe", "send")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithFormUrlEncodedAsync<Models.RestTemplateMessageSubscribeSendResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
