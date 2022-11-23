using Flurl;
using Flurl.Http;
using SKIT.FlurlHttpClient.Baidu.SmartApp.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp
{
    public static class SmartAppClientExecuteAuthExtensions
    {
        /// <summary>
        /// 获取第三方平台的接口调用凭据
        /// <para>异步调用 [GET] /public/2.0/smartapp/auth/tp/token 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/auth/access_token </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<AuthThirdPartyTokenResponse> ExecuteSmartAppAuthThirdPartyTokenAsync(this SmartAppThirdPartyClient client, AuthThirdPartyTokenRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "public", "2.0", "smartapp", "auth", "tp", "token")
                .SetQueryParam("client_id", request.ClientId)
                .SetQueryParam("ticket", request.Ticket);

            return await client.SendRequestWithJsonAsync<AuthThirdPartyTokenResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 获取预授权码
        /// <para>异步调用 [GET] rest/2.0/smartapp/tp/createpreauthcode 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/auth/pre_auth_code </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<CreatePreAuthCodeResponse> ExecuteSmartAppThirdPartyCreatePreAuthCodeAsync(this SmartAppThirdPartyClient client, CreatePreAuthCodeRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "tp", "createpreauthcode")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<CreatePreAuthCodeResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>生成第三方平台进行授权 URL。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/auth/guide </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="preAuthCode"></param>
        /// <param name="redirectUrl"></param>
        /// <returns></returns>
        public static string GenerateParameterizedUrlForAuth(this SmartAppThirdPartyClient client, string preAuthCode, string redirectUrl)
        {
            return new Url("https://smartprogram.baidu.com/developer/tpservice.html")
                .SetQueryParam("client_id", client.Credentials.AppKey)
                .SetQueryParam("pre_auth_code", preAuthCode)
                .SetQueryParam("redirect_uri", redirectUrl)
                .ToString();
        }

        /// <summary>
        /// 换取小程序的接口调用凭据
        /// <para>异步调用 [GET] rest/2.0/oauth/token 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/auth/get_auth_info </para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/auth/refresh_access_token </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<RestOAuthTokenResponse> ExecuteRestOAuthTokenAsync(this SmartAppThirdPartyClient client, RestOAuthTokenRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "oauth", "token")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("grant_type", request.GrantType);

            if (string.IsNullOrWhiteSpace(request.Code) == false)
                flurlReq.SetQueryParam("code", request.Code);

            if (string.IsNullOrWhiteSpace(request.RefreshToken) == false)
                flurlReq.SetQueryParam("refresh_token", request.RefreshToken);

            return await client.SendRequestWithJsonAsync<RestOAuthTokenResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 找回授权码
        /// <para>异步调用 [POST] rest/2.0/smartapp/auth/retrieve/authorizationcode 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/auth/refresh_token </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<RetrieveAuthorizationCodeResponse> ExecuteSmartAppAuthRetrieveAuthorizationCodeAsync(this SmartAppThirdPartyClient client, RetrieveAuthorizationCodeRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "auth", "retrieve", "authorizationcode")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("app_id", request.AuthorizeAppId);

            return await client.SendRequestWithJsonAsync<RetrieveAuthorizationCodeResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 法人人脸识别认证
        /// <para>异步调用 [GET] rest/2.0/smartapp/auth/faceauthen 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/advanced_auth/face_auth </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<FaceAuthenResponse> ExecuteSmartAppAuthFaceAuthenAsync(this SmartAppThirdPartyClient client, FaceAuthenRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "auth", "faceauthen")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<FaceAuthenResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 法人人脸识别认证
        /// <para>异步调用 [GET] rest/2.0/smartapp/auth/faceauthen 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/advanced_auth/public_auth </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<PaymentCertificationResponse> ExecuteSmartAppAuthPaymentCertificationAsync(this SmartAppThirdPartyClient client, PaymentCertificationRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "auth", "paymentCertification")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<PaymentCertificationResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 授权小程序登录
        /// <para>异步调用 [GET] rest/2.0/oauth/getsessionkeybycode 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/login/oauth </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<GetSessionKeyByCodeResponse> ExecuteOAuthGetSessionKeyByCodeAsync(this SmartAppThirdPartyClient client, GetSessionKeyByCodeRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "oauth", "getsessionkeybycode")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("code", request.Code)
                .SetQueryParam("grant_type", request.GrantType);

            return await client.SendRequestWithJsonAsync<GetSessionKeyByCodeResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 获取unionid
        /// <para>异步调用 [GET] rest/2.0/smartapp/unionId/get 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/login/unionid </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<GetUnionIdResponse> ExecuteSmartAppUnionIdGetAsync(this SmartAppThirdPartyClient client, GetUnionIdRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "unionId", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("open_id", request.OpenId);

            return await client.SendRequestWithJsonAsync<GetUnionIdResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }






    }
}
