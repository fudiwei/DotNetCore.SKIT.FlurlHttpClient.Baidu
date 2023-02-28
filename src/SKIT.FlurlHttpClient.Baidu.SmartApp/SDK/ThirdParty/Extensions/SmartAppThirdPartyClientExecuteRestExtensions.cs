using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty
{
    public static class SmartAppThirdPartyClientExecuteRestExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/oauth/token 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/auth/get_auth_info/ </para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/auth/refresh_access_token/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestOAuthTokenResponse> ExecuteRestOAuthTokenAsync(this BaiduSmartAppThirdPartyClient client, Models.RestOAuthTokenRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "oauth", "token")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("code", request.Code)
                .SetQueryParam("refresh_token", request.RefreshToken)
                .SetQueryParam("grant_type", request.GrantType);

            return await client.SendRequestWithJsonAsync<Models.RestOAuthTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/oauth/getsessionkeybycode 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/login/oauth/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestOAuthGetSessionKeyByCodeResponse> ExecuteRestOAuthGetSessionKeyByCodeAsync(this BaiduSmartAppThirdPartyClient client, Models.RestOAuthGetSessionKeyByCodeRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "oauth", "getsessionkeybycode")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("grant_type", request.GrantType)
                .SetQueryParam("code", request.Code);

            return await client.SendRequestWithJsonAsync<Models.RestOAuthGetSessionKeyByCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/unionId/get 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/login/unionid/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestUnionIdGetResponse> ExecuteRestUnionIdGetAsync(this BaiduSmartAppThirdPartyClient client, Models.RestUnionIdGetRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "unionId", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId);

            return await client.SendRequestWithJsonAsync<Models.RestUnionIdGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/tp/createpreauthcode 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/auth/pre_auth_code </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestThirdPartyCreatePreAuthCodeResponse> ExecuteRestThirdPartyCreatePreAuthCodeAsync(this BaiduSmartAppThirdPartyClient client, Models.RestThirdPartyCreatePreAuthCodeRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "tp", "createpreauthcode")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RestThirdPartyCreatePreAuthCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region App
        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/app/info 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/auth/app_info/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAppInfoResponse> ExecuteRestAppInfoAsync(this BaiduSmartAppThirdPartyClient client, Models.RestAppInfoRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "app", "info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RestAppInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/app/setnicknamewithqual 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/info/modify_app_name_with_qualification/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAppSetNickNameWithQualificationResponse> ExecuteRestAppSetNickNameWithQualificationAsync(this BaiduSmartAppThirdPartyClient client, Models.RestAppSetNickNameWithQualificationRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "app", "setnicknamewithqual")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("nick_name", request.AppName);

            if (request.QualificationMaterial != null)
                flurlReq.SetQueryParam("qual_materials", client.JsonSerializer.Serialize(request.QualificationMaterial));

            return await client.SendRequestWithJsonAsync<Models.RestAppSetNickNameWithQualificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/app/checknamewithqual 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/info/app_name_check/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAppCheckNameWithQualificationResponse> ExecuteRestAppCheckNameWithQualificationAsync(this BaiduSmartAppThirdPartyClient client, Models.RestAppCheckNameWithQualificationRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "app", "checknamewithqual")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("app_name", request.AppName);

            if (request.QualificationMaterial != null)
                flurlReq.SetQueryParam("qual_materials", client.JsonSerializer.Serialize(request.QualificationMaterial));

            return await client.SendRequestWithJsonAsync<Models.RestAppCheckNameWithQualificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/app/modifyheadimage 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/info/modify_app_icon/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAppModifyHeadImageResponse> ExecuteRestAppModifyHeadImageAsync(this BaiduSmartAppThirdPartyClient client, Models.RestAppModifyHeadImageRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "app", "modifyheadimage")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("image_url", request.ImageUrl);

            return await client.SendRequestWithJsonAsync<Models.RestAppModifyHeadImageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/app/modifysignature 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/info/modify_app_desc/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAppModifySignatureResponse> ExecuteRestAppModifySignatureAsync(this BaiduSmartAppThirdPartyClient client, Models.RestAppModifySignatureRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "app", "modifysignature")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("signature", request.AppDescription);

            return await client.SendRequestWithJsonAsync<Models.RestAppModifySignatureResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/app/category/update 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/info/modify_app_category/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAppCategoryUpdateResponse> ExecuteRestAppCategoryUpdateAsync(this BaiduSmartAppThirdPartyClient client, Models.RestAppCategoryUpdateRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "app", "category", "update")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.CategoryList != null)
                flurlReq.SetQueryParam("categorys", client.JsonSerializer.Serialize(request.CategoryList));

            return await client.SendRequestWithJsonAsync<Models.RestAppCategoryUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/app/category/list 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/info/category_list/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAppCategoryListResponse> ExecuteRestAppCategoryListAsync(this BaiduSmartAppThirdPartyClient client, Models.RestAppCategoryListRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "app", "category", "list")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("category_type", request.CategoryType);

            return await client.SendRequestWithJsonAsync<Models.RestAppCategoryListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/app/pause 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/info/service_pause/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAppPauseResponse> ExecuteRestAppPauseAsync(this BaiduSmartAppThirdPartyClient client, Models.RestAppPauseRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "app", "pause")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RestAppPauseResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/app/resume 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/info/service_start/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAppResumeResponse> ExecuteRestAppResumeAsync(this BaiduSmartAppThirdPartyClient client, Models.RestAppResumeRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "app", "resume")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RestAppResumeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/appflow/control 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/info/app_flow_control/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAppFlowControlResponse> ExecuteRestAppFlowControlAsync(this BaiduSmartAppThirdPartyClient client, Models.RestAppFlowControlRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "appflow", "control")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RestAppFlowControlResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/app/qrcode 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/info/qrcode/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAppQrcodeResponse> ExecuteRestAppQrcodeAsync(this BaiduSmartAppThirdPartyClient client, Models.RestAppQrcodeRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "app", "qrcode")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.PagePath != null)
                flurlReq.SetQueryParam("path", request.PagePath);

            if (request.PackageId != null)
                flurlReq.SetQueryParam("package_id", request.PackageId.Value);

            if (request.Width != null)
                flurlReq.SetQueryParam("width", request.Width.Value);

            return await client.SendRequestWithJsonAsync<Models.RestAppQrcodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/app/modifydomain 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/info/set_server_domain/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAppModifyDomainResponse> ExecuteRestAppModifyDomainAsync(this BaiduSmartAppThirdPartyClient client, Models.RestAppModifyDomainRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "app", "modifydomain")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("action", request.Action);

            if (request.RequestDomainList != null)
                flurlReq.SetQueryParam("request_domain", string.Join(",", request.RequestDomainList));

            if (request.UploadDomainList != null)
                flurlReq.SetQueryParam("upload_domain", string.Join(",", request.UploadDomainList));

            if (request.DownloadDomainList != null)
                flurlReq.SetQueryParam("download_domain", string.Join(",", request.DownloadDomainList));

            if (request.SocketDomainList != null)
                flurlReq.SetQueryParam("socket_domain", string.Join(",", request.SocketDomainList));

            return await client.SendRequestWithJsonAsync<Models.RestAppModifyDomainResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/app/modifywebviewdomain 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/info/set_biz_domain/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAppModifyWebviewDomainResponse> ExecuteRestAppModifyWebviewDomainAsync(this BaiduSmartAppThirdPartyClient client, Models.RestAppModifyWebviewDomainRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "app", "modifywebviewdomain")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("action", request.Action);

            if (request.WebViewDomainList != null)
                flurlReq.SetQueryParam("web_view_domain", string.Join(",", request.WebViewDomainList));

            return await client.SendRequestWithJsonAsync<Models.RestAppModifyWebviewDomainResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region App/Grade
        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/app/grade 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/app_grade/grade/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAppGradeResponse> ExecuteRestAppGradeAsync(this BaiduSmartAppThirdPartyClient client, Models.RestAppGradeRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "app", "grade")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("page", request.Page)
                .SetQueryParam("pageSize", request.PageSize);

            return await client.SendRequestWithJsonAsync<Models.RestAppGradeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region App/Offline
        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/app/offline/update 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/offline/updateinfo/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAppOfflineUpdateResponse> ExecuteRestAppOfflineUpdateAsync(this BaiduSmartAppThirdPartyClient client, Models.RestAppOfflineUpdateRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "app", "offline", "update")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("app_name", request.AppName)
                .SetQueryParam("app_desc", request.AppDescription)
                .SetQueryParam("photo_addr", request.HeadImageUrl)
                .SetQueryParam("app_name_material", request.AppNameMaterial);

            return await client.SendRequestWithJsonAsync<Models.RestAppOfflineUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/app/violation 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/offline/violationinfo/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAppViolationResponse> ExecuteRestAppViolationAsync(this BaiduSmartAppThirdPartyClient client, Models.RestAppViolationRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "app", "violation")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RestAppViolationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region App/Phone
        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/app/apply/mobileauth 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/phone/apply_phone/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAppApplyMobileAuthResponse> ExecuteRestAppApplyMobileAuthAsync(this BaiduSmartAppThirdPartyClient client, Models.RestAppApplyMobileAuthRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "app", "apply", "mobileauth")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("reason", request.ReasonType)
                .SetQueryParam("used_scene", request.Scene)
                .SetQueryParam("scene_desc", request.SceneDescription)
                .SetQueryParam("scene_demo", request.SceneDemoUrl);

            return await client.SendRequestWithJsonAsync<Models.RestAppApplyMobileAuthResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/app/cancel/mobileauth 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/phone/cancel_phone/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAppCancelMobileAuthResponse> ExecuteRestAppCancelMobileAuthAsync(this BaiduSmartAppThirdPartyClient client, Models.RestAppCancelMobileAuthRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "app", "cancel", "mobileauth")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RestAppCancelMobileAuthResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/app/get/mobileauthstatus 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/phone/phone_privilege/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAppGetMobileAuthStatusResponse> ExecuteRestAppGetMobileAuthStatusAsync(this BaiduSmartAppThirdPartyClient client, Models.RestAppGetMobileAuthStatusRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "app", "get", "mobileauthstatus")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RestAppGetMobileAuthStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion

        #region Auth
        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/auth/retrieve/authorizationcode 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/auth/refresh_token/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAuthRetrieveAuthorizationCodeResponse> ExecuteRestAuthRetrieveAuthorizationCodeAsync(this BaiduSmartAppThirdPartyClient client, Models.RestAuthRetrieveAuthorizationCodeRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "auth", "retrieve", "authorizationcode")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("app_id", request.AuthorizerAppId);

            return await client.SendRequestWithJsonAsync<Models.RestAuthRetrieveAuthorizationCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/auth/faceauthen 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/advanced_auth/face_auth/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAuthFaceAuthenResponse> ExecuteRestAuthFaceAuthenAsync(this BaiduSmartAppThirdPartyClient client, Models.RestAuthFaceAuthenRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "auth", "faceauthen")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RestAuthFaceAuthenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/auth/paymentCertification 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/advanced_auth/public_auth/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestAuthPaymentCertificationResponse> ExecuteRestAuthPaymentCertificationAsync(this BaiduSmartAppThirdPartyClient client, Models.RestAuthPaymentCertificationRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "auth", "paymentCertification")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RestAuthPaymentCertificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Package
        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/package/upload 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/package/upload/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestPackageUploadResponse> ExecuteRestPackageUploadAsync(this BaiduSmartAppThirdPartyClient client, Models.RestPackageUploadRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "package", "upload")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("ext_json", request.ExtJson)
                .SetQueryParam("template_id", request.TemplateId)
                .SetQueryParam("user_version", request.UserVersion)
                .SetQueryParam("user_desc", request.UserDescription)
                .SetQueryParam("test_account", request.TestAccount)
                .SetQueryParam("test_password", request.TestPassword);

            return await client.SendRequestWithJsonAsync<Models.RestPackageUploadResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/package/submitaudit 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/package/submitaudit/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestPackageSubmitAuditResponse> ExecuteRestPackageSubmitAuditAsync(this BaiduSmartAppThirdPartyClient client, Models.RestPackageSubmitAuditRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "package", "submitaudit")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("package_id", request.PackageId)
                .SetQueryParam("content", request.Content)
                .SetQueryParam("remark", request.Remark)
                .SetQueryParam("test_account", request.TestAccount)
                .SetQueryParam("test_password", request.TestPassword);

            return await client.SendRequestWithJsonAsync<Models.RestPackageSubmitAuditResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/package/auditquota 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/package/auditquota/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestPackageAuditQuotaResponse> ExecuteRestPackageAuditQuotaAsync(this BaiduSmartAppThirdPartyClient client, Models.RestPackageAuditQuotaRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "package", "auditquota")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RestPackageAuditQuotaResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/package/withdraw 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/package/withdraw/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestPackageWithdrawResponse> ExecuteRestPackageWithdrawAsync(this BaiduSmartAppThirdPartyClient client, Models.RestPackageWithdrawRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "package", "withdraw")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("package_id", request.PackageId);

            return await client.SendRequestWithJsonAsync<Models.RestPackageWithdrawResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/package/release 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/package/release/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestPackageReleaseResponse> ExecuteRestPackageReleaseAsync(this BaiduSmartAppThirdPartyClient client, Models.RestPackageReleaseRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "package", "release")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("package_id", request.PackageId);

            return await client.SendRequestWithJsonAsync<Models.RestPackageReleaseResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/package/rollback 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/package/rollback/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestPackageRollbackResponse> ExecuteRestPackageRollbackAsync(this BaiduSmartAppThirdPartyClient client, Models.RestPackageRollbackRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "package", "rollback")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("package_id", request.PackageId);

            return await client.SendRequestWithJsonAsync<Models.RestPackageRollbackResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/package/get 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/package/get/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestPackageGetResponse> ExecuteRestPackageGetAsync(this BaiduSmartAppThirdPartyClient client, Models.RestPackageGetRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "package", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RestPackageGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/package/getdetail 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/package/getdetail/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestPackageGetDetailResponse> ExecuteRestPackageGetDetailAsync(this BaiduSmartAppThirdPartyClient client, Models.RestPackageGetDetailRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "package", "getdetail")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.Type != null)
                flurlReq.SetQueryParam("type", request.Type.Value);

            if (request.PackageId != null)
                flurlReq.SetQueryParam("package_id", request.PackageId.Value);

            return await client.SendRequestWithJsonAsync<Models.RestPackageGetDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Prelink
        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/prelink/set 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/optimization/prelink_submit/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestPrelinkSetResponse> ExecuteRestPrelinkSetAsync(this BaiduSmartAppThirdPartyClient client, Models.RestPrelinkSetRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "prelink", "set")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("prelink_url", string.Join(",", request.PrelinkUrlList));

            return await client.SendRequestWithJsonAsync<Models.RestPrelinkSetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/prelink/get 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/optimization/prelink_get/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestPrelinkGetResponse> ExecuteRestPrelinkGetAsync(this BaiduSmartAppThirdPartyClient client, Models.RestPrelinkGetRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "prelink", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RestPrelinkGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Template
        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/template/gettemplatedraftlist 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/template/gettemplatedraftlist/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestTemplateGetTemplateDraftListResponse> ExecuteRestTemplateGetTemplateDraftListAsync(this BaiduSmartAppThirdPartyClient client, Models.RestTemplateGetTemplateDraftListRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "template", "gettemplatedraftlist")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("page", request.Page)
                .SetQueryParam("page_size", request.PageSize);

            return await client.SendRequestWithJsonAsync<Models.RestTemplateGetTemplateDraftListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/template/gettemplatelist 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/template/gettemplatelist/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestTemplateGetTemplateListResponse> ExecuteRestTemplateGetTemplateListAsync(this BaiduSmartAppThirdPartyClient client, Models.RestTemplateGetTemplateListRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "template", "gettemplatelist")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("page", request.Page)
                .SetQueryParam("page_size", request.PageSize);

            return await client.SendRequestWithJsonAsync<Models.RestTemplateGetTemplateListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/template/addtotemplate 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/template/addtotemplate/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestTemplateAddToTemplateResponse> ExecuteRestTemplateAddToTemplateAsync(this BaiduSmartAppThirdPartyClient client, Models.RestTemplateAddToTemplateRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "template", "addtotemplate")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("draft_id", request.DraftId)
                .SetQueryParam("user_desc", request.UserDescription);

            return await client.SendRequestWithJsonAsync<Models.RestTemplateAddToTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/template/deltemplate 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/template/deltemplate/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestTemplateDeleteTemplateResponse> ExecuteRestTemplateDeleteTemplateAsync(this BaiduSmartAppThirdPartyClient client, Models.RestTemplateDeleteTemplateRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "template", "deltemplate")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("template_id", request.TemplateId);

            return await client.SendRequestWithJsonAsync<Models.RestTemplateDeleteTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region TemplateMessage
        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/template/library/list 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/message_template/template_list/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestTemplateLibraryListResponse> ExecuteRestTemplateLibraryListAsync(this BaiduSmartAppThirdPartyClient client, Models.RestTemplateLibraryListRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "template", "library", "list")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("count", request.PageSize);

            return await client.SendRequestWithJsonAsync<Models.RestTemplateLibraryListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/template/library/get 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/message_template/word_lib/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestTemplateLibraryGetResponse> ExecuteRestTemplateLibraryGetAsync(this BaiduSmartAppThirdPartyClient client, Models.RestTemplateLibraryGetRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "template", "library", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("id", request.Id);

            return await client.SendRequestWithJsonAsync<Models.RestTemplateLibraryGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rest/2.0/smartapp/template/list 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/message_template/get_template_list/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestTemplateListResponse> ExecuteRestTemplateListAsync(this BaiduSmartAppThirdPartyClient client, Models.RestTemplateListRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "template", "list")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("count", request.PageSize);

            return await client.SendRequestWithJsonAsync<Models.RestTemplateListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/template/add 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/message_template/add_template/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestTemplateAddResponse> ExecuteRestTemplateAddAsync(this BaiduSmartAppThirdPartyClient client, Models.RestTemplateAddRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "template", "add")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("id", request.Id)
                .SetQueryParam("keyword_id_list", client.JsonSerializer.Serialize(request.KeywordIdList));

            return await client.SendRequestWithJsonAsync<Models.RestTemplateAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/template/del 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/message_template/delete_template/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestTemplateDeleteResponse> ExecuteRestTemplateDeleteAsync(this BaiduSmartAppThirdPartyClient client, Models.RestTemplateDeleteRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "template", "del")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("template_id", request.TemplateId);

            return await client.SendRequestWithJsonAsync<Models.RestTemplateDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /rest/2.0/smartapp/template/sendmessage 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/message_template/template_push/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestTemplateSendMessageResponse> ExecuteRestTemplateSendMessageAsync(this BaiduSmartAppThirdPartyClient client, Models.RestTemplateSendMessageRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "template", "sendmessage")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("template_id", request.TemplateId)
                .SetQueryParam("touser_openId", request.ToUserOpenId);

            if (request.Data != null)
                flurlReq.SetQueryParam("data", client.JsonSerializer.Serialize(request.Data));

            if (request.PagePath != null)
                flurlReq.SetQueryParam("page", request.PagePath);

            if (request.SceneId != null)
                flurlReq.SetQueryParam("scene_id", request.SceneId);

            if (request.SceneType != null)
                flurlReq.SetQueryParam("scene_type", request.SceneType);

            return await client.SendRequestWithJsonAsync<Models.RestTemplateSendMessageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
