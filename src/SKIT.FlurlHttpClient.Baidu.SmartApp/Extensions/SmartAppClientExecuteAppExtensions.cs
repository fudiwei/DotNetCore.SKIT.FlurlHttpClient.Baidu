using Flurl.Http;
using SKIT.FlurlHttpClient.Baidu.SmartApp.Models.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp
{
    public static class SmartAppClientExecuteAppExtensions
    {
        /// <summary>
        /// 获取小程序基础信息
        /// <para>异步调用 [GET] rest/2.0/smartapp/app/info 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/auth/app_info </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<AppInfoResponse> ExecuteSmartAppAppInfoAsync(this SmartAppThirdPartyClient client, AppInfoRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "app", "info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<AppInfoResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 设置小程序服务器域名
        /// <para>异步调用 [POST] rest/2.0/smartapp/app/modifydomain 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/info/set_server_domain </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<ModifyDomainResponse> ExecuteSmartAppModifyDomainAsync(this SmartAppThirdPartyClient client, ModifyDomainRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "app", "modifydomain")
                .SetQueryParam("access_token", request.AccessToken);

            if (string.IsNullOrWhiteSpace(request.Action) == false)
                flurlReq.SetQueryParam("action", request.Action);
            if (string.IsNullOrWhiteSpace(request.DownloadDomain) == false)
                flurlReq.SetQueryParam("download_domain", request.Action);
            if (string.IsNullOrWhiteSpace(request.RequestDomain) == false)
                flurlReq.SetQueryParam("request_domain", request.Action);
            if (string.IsNullOrWhiteSpace(request.SocketDomain) == false)
                flurlReq.SetQueryParam("socket_domain", request.Action);
            if (string.IsNullOrWhiteSpace(request.UploadDomain) == false)
                flurlReq.SetQueryParam("upload_domain", request.Action);

            return await client.SendRequestWithJsonAsync<ModifyDomainResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 设置小程序业务域名
        /// <para>异步调用 [POST] rest/2.0/smartapp/app/modifywebviewdomain 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/info/set_biz_domain </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<ModifyWebviewDomainResponse> ExecuteSmartAppModifyWebViewDomainAsync(this SmartAppThirdPartyClient client, ModifyWebviewDomainRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "app", "modifywebviewdomain")
                .SetQueryParam("access_token", request.AccessToken);

            if (string.IsNullOrWhiteSpace(request.Action) == false)
                flurlReq.SetQueryParam("action", request.Action);
            if (string.IsNullOrWhiteSpace(request.WebViewDomain) == false)
                flurlReq.SetQueryParam("web_view_domain", request.WebViewDomain);

            return await client.SendRequestWithJsonAsync<ModifyWebviewDomainResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 获取二维码TP
        /// <para>异步调用 [GET] rest/2.0/smartapp/app/qrcode 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/info/qrcode </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<QrCodeResponse> ExecuteSmartAppQrCodeAsync(this SmartAppThirdPartyClient client, QrCodeRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "app", "qrcode")
                .SetQueryParam("access_token", request.AccessToken);

            if (string.IsNullOrWhiteSpace(request.Path) == false)
                flurlReq.SetQueryParam("path", request.Path);
            if (string.IsNullOrWhiteSpace(request.PackageId) == false)
                flurlReq.SetQueryParam("package_id", request.PackageId);
            if (request.Width.HasValue)
                flurlReq.SetQueryParam("width", request.Width);

            return await client.SendRequestWithJsonAsync<QrCodeResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 申请手机号权限
        /// <para>异步调用 [POST] rest/2.0/smartapp/app/apply/mobileauth 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/phone/apply_phone/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<ApplyMobileAuthResponse> ExecuteSmartAppApplyMobileAuthAsync(this SmartAppThirdPartyClient client, ApplyMobileAuthRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "app", "apply", "mobileauth")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("reason", request.Reason)
                .SetQueryParam("used_scene", request.UsedScene)
                .SetQueryParam("scene_desc", request.SceneDesc)
                .SetQueryParam("scene_demo", request.SceneDemo);

            return await client.SendRequestWithJsonAsync<ApplyMobileAuthResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 申请手机号权限
        /// <para>异步调用 [POST] rest/2.0/smartapp/app/apply/mobileauth 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/phone/cancel_phone </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<CancelMobileAuthResponse> ExecuteSmartAppApplyMobileAuthAsync(this SmartAppThirdPartyClient client, CancelMobileAuthRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "app", "cancel", "mobileauth")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<CancelMobileAuthResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 查询手机号权限状态
        /// <para>异步调用 [GET] rest/2.0/smartapp/app/get/mobileauthstatus 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/phone/phone_privilege </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<GetMobileAuthStatusResponse> ExecuteSmartAppGetMobileAuthStatusAsync(this SmartAppThirdPartyClient client, GetMobileAuthStatusRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "app", "get", "mobileauthstatus")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<GetMobileAuthStatusResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 获取小程序等级
        /// <para>异步调用 [GET] rest/2.0/smartapp/app/grade 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/app_grade/grade/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<AppGradeResponse> ExecuteSmartAppAppGradeAsync(this SmartAppThirdPartyClient client, AppGradeRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "app", "grade")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("page_no", request.PageNo);

            return await client.SendRequestWithJsonAsync<AppGradeResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 修改小程序名称
        /// <para>异步调用 [POST] rest/2.0/smartapp/app/setnicknamewithqual 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/info/modify_app_name_with_qualification </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<SetNickNameWithQualResponse> ExecuteSmartAppSetNickNameWithQualAsync(this SmartAppThirdPartyClient client, SetNickNameWithQualRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "app", "setnicknamewithqual")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("nick_name", request.NickName)
                .SetQueryParam("qual_materials", request.QualMaterials);

            return await client.SendRequestWithJsonAsync<SetNickNameWithQualResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 小程序名称检测
        /// <para>异步调用 [GET] rest/2.0/smartapp/app/checknamewithqual 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/info/app_name_check </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<CheckNameWithQualResponse> ExecuteSmartAppCheckNameWithQualAsync(this SmartAppThirdPartyClient client, CheckNameWithQualRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "app", "checknamewithqual")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("app_name", request.AppName)
                .SetQueryParam("qual_materials", request.QualMaterials);

            return await client.SendRequestWithJsonAsync<CheckNameWithQualResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 修改小程序icon
        /// <para>异步调用 [POST] rest/2.0/smartapp/app/modifyheadimage 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/info/modify_app_icon </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<ModifyHeadImageResponse> ExecuteSmartAppModifyHeadImageAsync(this SmartAppThirdPartyClient client, ModifyHeadImageRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "app", "modifyheadimage")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("image_url", request.ImageUrl);

            return await client.SendRequestWithJsonAsync<ModifyHeadImageResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 修改小程序简介
        /// <para>异步调用 [POST] rest/2.0/smartapp/app/modifysignature 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/info/modify_app_desc </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<ModifySignatureResponse> ExecuteSmartAppModifySignatureAsync(this SmartAppThirdPartyClient client, ModifySignatureRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "app", "modifysignature")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("signature", request.Signature);

            return await client.SendRequestWithJsonAsync<ModifySignatureResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }



    }
}
