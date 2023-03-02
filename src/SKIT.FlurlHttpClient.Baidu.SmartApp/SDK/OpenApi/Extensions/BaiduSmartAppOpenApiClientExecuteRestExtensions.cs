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

        #region Access
        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/access/submitresource 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/submitresource/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAccessSubmitResourceResponse> ExecuteRestAccessSubmitResourceAsync(this BaiduSmartAppOpenApiClient client, Models.RestAccessSubmitResourceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "access", "submitresource")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithFormUrlEncodedAsync<Models.RestAccessSubmitResourceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/access/deleteresource 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/deleteresource/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAccessDeleteResourceResponse> ExecuteRestAccessDeleteResourceAsync(this BaiduSmartAppOpenApiClient client, Models.RestAccessDeleteResourceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "access", "deleteresource")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("app_id", request.AppId)
                .SetQueryParam("path", request.PagePath);

            return await client.SendRequestWithFormUrlEncodedAsync<Models.RestAccessDeleteResourceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/access/submitsitemap 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/submitsitemap/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAccessSubmitSitemapResponse> ExecuteRestAccessSubmitSitemapAsync(this BaiduSmartAppOpenApiClient client, Models.RestAccessSubmitSitemapRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "access", "submitsitemap")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithFormUrlEncodedAsync<Models.RestAccessSubmitSitemapResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/access/deletesitemap 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/deletesitemap/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAccessDeleteSitemapResponse> ExecuteRestAccessDeleteSitemapAsync(this BaiduSmartAppOpenApiClient client, Models.RestAccessDeleteSitemapRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "access", "deletesitemap")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("app_id", request.AppId)
                .SetQueryParam("url", request.SitemapUrl);

            return await client.SendRequestWithFormUrlEncodedAsync<Models.RestAccessDeleteSitemapResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/access/submitsitemap/api 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/operations/flow/configurable/rank_api/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAccessSubmitSitemapApiResponse> ExecuteRestAccessSubmitSitemapApiAsync(this BaiduSmartAppOpenApiClient client, Models.RestAccessSubmitSitemapApiRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "access", "submitsitemap", "api")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("type", request.UploadType)
                .SetQueryParam("url_list", string.Join(",", request.UrlList));

            return await client.SendRequestWithFormUrlEncodedAsync<Models.RestAccessSubmitSitemapApiResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Coupon
        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/v1.0/coupon/create 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/api/open/coupons_create_type/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestCouponCreateResponse> ExecuteRestCouponCreateAsync(this BaiduSmartAppOpenApiClient client, Models.RestCouponCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "v1.0", "coupon", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RestCouponCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/v1.0/coupon/upload/image 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/api/open/coupons_create_banner/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestCouponUploadImageResponse> ExecuteRestCouponUploadImageAsync(this BaiduSmartAppOpenApiClient client, Models.RestCouponUploadImageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "v1.0", "coupon", "upload", "image")
                .SetQueryParam("access_token", request.AccessToken);

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: "image.jpg", fileBytes: request.ImageFileBytes, fileContentType: "image/jpeg", formDataName: "file");
            return await client.SendRequestAsync<Models.RestCouponUploadImageResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/v1.0/coupon/code/batchUpload 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/api/open/coupons_create_code/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestCouponCodeBatchUploadResponse> ExecuteRestCouponCodeBatchUploadAsync(this BaiduSmartAppOpenApiClient client, Models.RestCouponCodeBatchUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "v1.0", "coupon", "code", "batchUpload")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RestCouponCodeBatchUploadResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/v1.0/coupon/send 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/api/open/coupons_bag/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestCouponSendResponse> ExecuteRestCouponSendAsync(this BaiduSmartAppOpenApiClient client, Models.RestCouponSendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "v1.0", "coupon", "send")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RestCouponSendResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/v1.0/coupon/code/consume 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/api/open/coupons_delete/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestCouponCodeConsumeResponse> ExecuteRestCouponCodeConsumeAsync(this BaiduSmartAppOpenApiClient client, Models.RestCouponCodeConsumeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "v1.0", "coupon", "code", "consume")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RestCouponCodeConsumeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/v1.0/coupon/return 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/api/open/coupons_delete/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestCouponReturnResponse> ExecuteRestCouponReturnAsync(this BaiduSmartAppOpenApiClient client, Models.RestCouponReturnRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "v1.0", "coupon", "return")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RestCouponReturnResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/v1.0/coupon/get 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/api/open/coupons_manage/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestCouponGetResponse> ExecuteRestCouponGetAsync(this BaiduSmartAppOpenApiClient client, Models.RestCouponGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "v1.0", "coupon", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("couponId", request.CouponId);

            return await client.SendRequestWithJsonAsync<Models.RestCouponGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/v1.0/coupon/batchGet 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/api/open/coupons_manage/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestCouponBatchGetResponse> ExecuteRestCouponBatchGetAsync(this BaiduSmartAppOpenApiClient client, Models.RestCouponBatchGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "v1.0", "coupon", "batchGet")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pageNum", request.PageNumber)
                .SetQueryParam("pageSize", request.PageSize);

            if (request.Title != null)
                flurlReq.SetQueryParam("title", request.Title);

            if (request.CouponType != null)
                flurlReq.SetQueryParam("couponType", request.CouponType);

            return await client.SendRequestWithJsonAsync<Models.RestCouponBatchGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/v1.0/coupon/delete 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/api/open/coupons_delete/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestCouponDeleteResponse> ExecuteRestCouponDeleteAsync(this BaiduSmartAppOpenApiClient client, Models.RestCouponDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "v1.0", "coupon", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RestCouponDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/v1.0/coupon/getSchema 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/api/open/coupons_test/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestCouponGetSchemaResponse> ExecuteRestCouponGetSchemaAsync(this BaiduSmartAppOpenApiClient client, Models.RestCouponGetSchemaRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "v1.0", "coupon", "getSchema")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("couponId", request.CouponId);

            return await client.SendRequestWithJsonAsync<Models.RestCouponGetSchemaResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Coupon/Banner
        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/v1.0/coupon/banner/add 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/api/open/coupons_create_banner/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestCouponBannerAddResponse> ExecuteRestCouponBannerAddAsync(this BaiduSmartAppOpenApiClient client, Models.RestCouponBannerAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "v1.0", "coupon", "banner", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RestCouponBannerAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/v1.0/coupon/banner/update 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/api/open/coupons_create_banner/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestCouponBannerUpdateResponse> ExecuteRestCouponBannerUpdateAsync(this BaiduSmartAppOpenApiClient client, Models.RestCouponBannerUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "v1.0", "coupon", "banner", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RestCouponBannerUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/v1.0/coupon/banner/delete 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/api/open/coupons_create_banner/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestCouponBannerDeleteResponse> ExecuteRestCouponBannerDeleteAsync(this BaiduSmartAppOpenApiClient client, Models.RestCouponBannerDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "v1.0", "coupon", "banner", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RestCouponBannerDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/v1.0/coupon/banner/get 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/api/open/coupons_create_banner/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestCouponBannerGetResponse> ExecuteRestCouponBannerGetAsync(this BaiduSmartAppOpenApiClient client, Models.RestCouponBannerGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "v1.0", "coupon", "banner", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("couponId", request.CouponId)
                .SetQueryParam("bannerIds", string.Join(",", request.BannerIdList));

            return await client.SendRequestWithJsonAsync<Models.RestCouponBannerGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/v1.0/coupon/banner/batchGet 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/api/open/coupons_create_banner/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestCouponBannerBatchGetResponse> ExecuteRestCouponBannerBatchGetAsync(this BaiduSmartAppOpenApiClient client, Models.RestCouponBannerBatchGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "v1.0", "coupon", "banner", "batchGet")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pageNum", request.PageNumber)
                .SetQueryParam("pageSize", request.PageSize);

            return await client.SendRequestWithJsonAsync<Models.RestCouponBannerBatchGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion

        #region MA
        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/ma/component/comment/tcount 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/interactive_comment_count/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestMAComponentCommentCountResponse> ExecuteRestMAComponentCommentCountAsync(this BaiduSmartAppOpenApiClient client, Models.RestMAComponentCommentCountRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "ma", "component", "comment", "tcount")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("snid", request.ContentId)
                .SetQueryParam("snid_type", request.ContentIdType);

            if (request.HostName != null)
                flurlReq.SetQueryParam("host_name", request.HostName);

            return await client.SendRequestWithJsonAsync<Models.RestMAComponentCommentCountResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/ma/component/comment/open_list 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/interactive_comment_list/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestMAComponentCommentOpenListResponse> ExecuteRestMAComponentCommentOpenListAsync(this BaiduSmartAppOpenApiClient client, Models.RestMAComponentCommentOpenListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "ma", "component", "comment", "open_list")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("snid", request.ContentId)
                .SetQueryParam("snid_type", request.ContentIdType)
                .SetQueryParam("start", request.PageOffset)
                .SetQueryParam("num", request.PageSize);

            if (request.HostName != null)
                flurlReq.SetQueryParam("host_name", request.HostName);

            return await client.SendRequestWithJsonAsync<Models.RestMAComponentCommentOpenListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region MessageCustom
        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/message/custom/send 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/contact_api_send/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestMessageCustomSendResponse> ExecuteRestMessageCustomSendAsync(this BaiduSmartAppOpenApiClient client, Models.RestMessageCustomSendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "message", "custom", "send")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("user_type", request.UserType)
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("msg_type", request.MessageType)
                .SetQueryParam("content", request.Content)
                .SetQueryParam("pic_url", request.PictureUrl);

            return await client.SendRequestWithJsonAsync<Models.RestMessageCustomSendResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region OrderCenter
        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/ordercenter/app/add/main/info 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/order/add_order/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestOrderCenterAppAddMainInfoResponse> ExecuteRestOrderCenterAppAddMainInfoAsync(this BaiduSmartAppOpenApiClient client, Models.RestOrderCenterAppAddMainInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.PaymentServiceAppKey == null)
                request.PaymentServiceAppKey = client.Credentials.PaymentServiceAppKey;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "ordercenter", "app", "add", "main", "info")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pm_app_key", request.PaymentServiceAppKey)
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("swan_id", request.SwanId)
                .SetQueryParam("scene_id", request.SceneId)
                .SetQueryParam("scene_type", request.SceneType);

            if (request.HostName != null)
                flurlReq.SetQueryParams("hostname", request.HostName);

            return await client.SendRequestWithJsonAsync<Models.RestOrderCenterAppAddMainInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/ordercenter/app/update/main/info 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/order/update_order_info/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestOrderCenterAppUpdateMainInfoResponse> ExecuteRestOrderCenterAppUpdateMainInfoAsync(this BaiduSmartAppOpenApiClient client, Models.RestOrderCenterAppUpdateMainInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.PaymentServiceAppKey == null)
                request.PaymentServiceAppKey = client.Credentials.PaymentServiceAppKey;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "ordercenter", "app", "update", "main", "info")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pm_app_key", request.PaymentServiceAppKey)
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("swan_id", request.SwanId)
                .SetQueryParam("scene_id", request.SceneId)
                .SetQueryParam("scene_type", request.SceneType);

            if (request.HostName != null)
                flurlReq.SetQueryParams("hostname", request.HostName);

            return await client.SendRequestWithJsonAsync<Models.RestOrderCenterAppUpdateMainInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/ordercenter/app/update/main/status 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/order/update_order_status/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestOrderCenterAppUpdateMainStatusResponse> ExecuteRestOrderCenterAppUpdateMainStatusAsync(this BaiduSmartAppOpenApiClient client, Models.RestOrderCenterAppUpdateMainStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.PaymentServiceAppKey == null)
                request.PaymentServiceAppKey = client.Credentials.PaymentServiceAppKey;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "ordercenter", "app", "update", "main", "status")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pm_app_key", request.PaymentServiceAppKey)
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("swan_id", request.SwanId)
                .SetQueryParam("scene_id", request.SceneId)
                .SetQueryParam("scene_type", request.SceneType);

            if (request.HostName != null)
                flurlReq.SetQueryParams("hostname", request.HostName);

            return await client.SendRequestWithJsonAsync<Models.RestOrderCenterAppUpdateMainStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/ordercenter/app/update/main/logistics 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/order_importupdate/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestOrderCenterAppUpdateMainLogisticsResponse> ExecuteRestOrderCenterAppUpdateMainLogisticsAsync(this BaiduSmartAppOpenApiClient client, Models.RestOrderCenterAppUpdateMainLogisticsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.PaymentServiceAppKey == null)
                request.PaymentServiceAppKey = client.Credentials.PaymentServiceAppKey;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "ordercenter", "app", "update", "main", "logistics")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pm_app_key", request.PaymentServiceAppKey)
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("swan_id", request.SwanId)
                .SetQueryParam("scene_id", request.SceneId)
                .SetQueryParam("scene_type", request.SceneType);

            if (request.HostName != null)
                flurlReq.SetQueryParams("hostname", request.HostName);

            return await client.SendRequestWithJsonAsync<Models.RestOrderCenterAppUpdateMainLogisticsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/ordercenter/app/append/sub/info 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/order/add_post_order/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestOrderCenterAppAppendSubInfoResponse> ExecuteRestOrderCenterAppAppendSubInfoAsync(this BaiduSmartAppOpenApiClient client, Models.RestOrderCenterAppAppendSubInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.PaymentServiceAppKey == null)
                request.PaymentServiceAppKey = client.Credentials.PaymentServiceAppKey;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "ordercenter", "app", "append", "sub", "info")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pm_app_key", request.PaymentServiceAppKey)
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("swan_id", request.SwanId)
                .SetQueryParam("scene_id", request.SceneId)
                .SetQueryParam("scene_type", request.SceneType);

            if (request.HostName != null)
                flurlReq.SetQueryParams("hostname", request.HostName);

            return await client.SendRequestWithJsonAsync<Models.RestOrderCenterAppAppendSubInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/ordercenter/app/update/sub/info 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/order/update_post_order_info/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestOrderCenterAppUpdateSubInfoResponse> ExecuteRestOrderCenterAppUpdateSubInfoAsync(this BaiduSmartAppOpenApiClient client, Models.RestOrderCenterAppUpdateSubInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.PaymentServiceAppKey == null)
                request.PaymentServiceAppKey = client.Credentials.PaymentServiceAppKey;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "ordercenter", "app", "update", "sub", "info")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pm_app_key", request.PaymentServiceAppKey)
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("swan_id", request.SwanId)
                .SetQueryParam("scene_id", request.SceneId)
                .SetQueryParam("scene_type", request.SceneType);

            if (request.HostName != null)
                flurlReq.SetQueryParams("hostname", request.HostName);

            return await client.SendRequestWithJsonAsync<Models.RestOrderCenterAppUpdateSubInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/ordercenter/app/update/sub/status 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/order/update_post_order_status/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestOrderCenterAppUpdateSubStatusResponse> ExecuteRestOrderCenterAppUpdateSubStatusAsync(this BaiduSmartAppOpenApiClient client, Models.RestOrderCenterAppUpdateSubStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.PaymentServiceAppKey == null)
                request.PaymentServiceAppKey = client.Credentials.PaymentServiceAppKey;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "ordercenter", "app", "update", "sub", "status")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pm_app_key", request.PaymentServiceAppKey)
                .SetQueryParam("open_id", request.OpenId)
                .SetQueryParam("swan_id", request.SwanId)
                .SetQueryParam("scene_id", request.SceneId)
                .SetQueryParam("scene_type", request.SceneType);

            if (request.HostName != null)
                flurlReq.SetQueryParams("hostname", request.HostName);

            return await client.SendRequestWithJsonAsync<Models.RestOrderCenterAppUpdateSubStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region OSS
        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/oss/publisher/ugc/like_count 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/interactive_like_count/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestOSSPublisherUGCLikeCountResponse> ExecuteRestOSSPublisherUGCLikeCountAsync(this BaiduSmartAppOpenApiClient client, Models.RestOSSPublisherUGCLikeCountRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "oss", "publisher", "ugc", "like_count")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("snid", request.ContentId)
                .SetQueryParam("snid_type", request.ContentIdType);

            if (request.HostName != null)
                flurlReq.SetQueryParam("host_name", request.HostName);

            return await client.SendRequestWithJsonAsync<Models.RestOSSPublisherUGCLikeCountResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Pay
        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/pay/paymentservice/findByTpOrderId 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/function/tune_up_queryorderdetail_2.0/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestPayPaymentServiceFindByOutOrderIdResponse> ExecuteRestPayPaymentServiceFindByOutOrderIdAsync(this BaiduSmartAppOpenApiClient client, Models.RestPayPaymentServiceFindByOutOrderIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.PaymentServiceAppKey == null)
                request.PaymentServiceAppKey = client.Credentials.PaymentServiceAppKey;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "pay", "paymentservice", "findByTpOrderId")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pmAppKey", request.PaymentServiceAppKey)
                .SetQueryParam("tpOrderId", request.OutOrderId);

            return await client.SendRequestWithFormUrlEncodedAsync<Models.RestPayPaymentServiceFindByOutOrderIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/pay/paymentservice/cancelOrder 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/function/tune_up_rest_2.0/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestPayPaymentServiceCancelOrderResponse> ExecuteRestPayPaymentServiceCancelOrderAsync(this BaiduSmartAppOpenApiClient client, Models.RestPayPaymentServiceCancelOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.PaymentServiceAppKey == null)
                request.PaymentServiceAppKey = client.Credentials.PaymentServiceAppKey;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "pay", "paymentservice", "cancelOrder")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pmAppKey", request.PaymentServiceAppKey)
                .SetQueryParam("orderId", request.OrderId);

            return await client.SendRequestWithFormUrlEncodedAsync<Models.RestPayPaymentServiceCancelOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/pay/paymentservice/applyOrderRefund 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/function/tune_up_applyorderrefund_2.0/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestPayPaymentServiceApplyOrderRefundResponse> ExecuteRestPayPaymentServiceApplyOrderRefundAsync(this BaiduSmartAppOpenApiClient client, Models.RestPayPaymentServiceApplyOrderRefundRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.PaymentServiceAppKey == null)
                request.PaymentServiceAppKey = client.Credentials.PaymentServiceAppKey;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "pay", "paymentservice", "applyOrderRefund")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pmAppKey", request.PaymentServiceAppKey)
                .SetQueryParam("tpOrderId", request.OutOrderId)
                .SetQueryParam("orderId", request.OrderId)
                .SetQueryParam("bizRefundBatchId", request.OutRefundBatchId)
                .SetQueryParam("applyRefundMoney", request.RefundAmount)
                .SetQueryParam("isSkipAudit", request.IsSkipAudit ? 1 : 0)
                .SetQueryParam("refundReason", request.RefundReason)
                .SetQueryParam("refundType", request.RefundType)
                .SetQueryParam("userId", request.UserId)
                .SetQueryParam("refundNotifyUrl", request.RefundNotifyUrl);

            return await client.SendRequestWithFormUrlEncodedAsync<Models.RestPayPaymentServiceApplyOrderRefundResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/pay/paymentservice/findOrderRefund 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/function/tune_up_examine_2.0/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestPayPaymentServiceFindOrderRefundResponse> ExecuteRestPayPaymentServiceFindOrderRefundAsync(this BaiduSmartAppOpenApiClient client, Models.RestPayPaymentServiceFindOrderRefundRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.PaymentServiceAppKey == null)
                request.PaymentServiceAppKey = client.Credentials.PaymentServiceAppKey;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "pay", "paymentservice", "findOrderRefund")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pmAppKey", request.PaymentServiceAppKey)
                .SetQueryParam("tpOrderId", request.OutOrderId)
                .SetQueryParam("userId", request.UserId);

            return await client.SendRequestWithFormUrlEncodedAsync<Models.RestPayPaymentServiceFindOrderRefundResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/pay/paymentservice/orderBill 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/function/tune_up_orderBill_2.0/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestPayPaymentServiceOrderBillResponse> ExecuteRestPayPaymentServiceOrderBillAsync(this BaiduSmartAppOpenApiClient client, Models.RestPayPaymentServiceOrderBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.PaymentServiceAppKey == null)
                request.PaymentServiceAppKey = client.Credentials.PaymentServiceAppKey;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "pay", "paymentservice", "orderBill")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pmAppKey", request.PaymentServiceAppKey)
                .SetQueryParam("billTime", request.BillDateString);

            return await client.SendRequestWithFormUrlEncodedAsync<Models.RestPayPaymentServiceOrderBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/pay/paymentservice/capitaBill 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/function/tune_up_capitaBill_2.0/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestPayPaymentServiceCapitaBillResponse> ExecuteRestPayPaymentServiceCapitaBillAsync(this BaiduSmartAppOpenApiClient client, Models.RestPayPaymentServiceCapitaBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.PaymentServiceAppKey == null)
                request.PaymentServiceAppKey = client.Credentials.PaymentServiceAppKey;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "pay", "paymentservice", "capitaBill")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pmAppKey", request.PaymentServiceAppKey)
                .SetQueryParam("billTime", request.BillDateString);

            return await client.SendRequestWithFormUrlEncodedAsync<Models.RestPayPaymentServiceCapitaBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

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
