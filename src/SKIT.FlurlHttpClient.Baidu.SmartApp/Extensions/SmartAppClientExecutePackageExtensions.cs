using Flurl.Http;
using SKIT.FlurlHttpClient.Baidu.SmartApp.Models.Package;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp
{
    public static class SmartAppClientExecutePackageExtensions
    {
        /// <summary>
        /// 授权小程序上传包
        /// <para>异步调用 [POST] rest/2.0/smartapp/package/upload 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/package/upload </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<PackageUploadResponse> ExecuteSmartAppPackageUploadAsync(this SmartAppThirdPartyClient client, PackageUploadRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "package", "upload")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("ext_json", request.ExtJson)
                .SetQueryParam("template_id", request.TemplateId)
                .SetQueryParam("user_desc", request.UserDesc)
                .SetQueryParam("user_version", request.UserVersion);

            if (string.IsNullOrWhiteSpace(request.TestAccount) == false)
                flurlReq.SetQueryParam("test_account", request.TestAccount);
            if (string.IsNullOrWhiteSpace(request.TestPassword) == false)
                flurlReq.SetQueryParam("test_password", request.TestPassword);

            return await client.SendRequestWithJsonAsync<PackageUploadResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 授权小程序提交审核
        /// <para>异步调用 [POST] rest/2.0/smartapp/package/submitaudit 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/package/submitaudit </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<PackageSubmitAuditResponse> ExecuteSmartAppPackageSubmitauditAsync(this SmartAppThirdPartyClient client, PackageSubmitAuditRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "package", "submitaudit")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("content", request.Content)
                .SetQueryParam("package_id", request.PackageId)
                .SetQueryParam("remark", request.Remark);

            if (string.IsNullOrWhiteSpace(request.TestAccount) == false)
                flurlReq.SetQueryParam("test_account", request.TestAccount);
            if (string.IsNullOrWhiteSpace(request.TestPassword) == false)
                flurlReq.SetQueryParam("test_password", request.TestPassword);

            return await client.SendRequestWithJsonAsync<PackageSubmitAuditResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 获取小程序包列表
        /// <para>异步调用 [GET] rest/2.0/smartapp/package/get 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/package/get </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<PackageGetResponse> ExecuteSmartAppPackageGetAsync(this SmartAppThirdPartyClient client, PackageGetRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "package", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<PackageGetResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 获取授权小程序送审额度
        /// <para>异步调用 [GET] rest/2.0/smartapp/package/auditquota 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/package/auditquota </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<PackageAuditQuotaResponse> ExecuteSmartAppPackageAuditQuotaAsync(this SmartAppThirdPartyClient client, PackageAuditQuotaRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "package", "auditquota")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<PackageAuditQuotaResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 授权小程序撤销审核
        /// <para>异步调用 [POST] rest/2.0/smartapp/package/withdraw 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/package/withdraw </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<PackageWithdrawResponse> ExecuteSmartAppPackageWithdrawAsync(this SmartAppThirdPartyClient client, PackageWithdrawRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "package", "withdraw")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("package_id", request.PackageId);

            return await client.SendRequestWithJsonAsync<PackageWithdrawResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 授权小程序发布
        /// <para>异步调用 [POST] rest/2.0/smartapp/package/release 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/package/release </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<PackageReleaseResponse> ExecuteSmartAppPackageReleaseAsync(this SmartAppThirdPartyClient client, PackageReleaseRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "package", "release")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("package_id", request.PackageId);

            return await client.SendRequestWithJsonAsync<PackageReleaseResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 授权小程序回滚包
        /// <para>异步调用 [POST] rest/2.0/smartapp/package/rollback 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/package/rollback </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<PackageRollbackResponse> ExecuteSmartAppPackageRollbackAsync(this SmartAppThirdPartyClient client, PackageRollbackRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "package", "rollback")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("package_id", request.PackageId);

            return await client.SendRequestWithJsonAsync<PackageRollbackResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 获取授权小程序包详情
        /// <para>异步调用 [GET] rest/2.0/smartapp/package/getdetail 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/package/getdetail </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<PackageGetDetailResponse> ExecuteSmartAppPackageGetDetailAsync(this SmartAppThirdPartyClient client, PackageGetDetailRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "package", "getdetail")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.Type.HasValue)
                flurlReq.SetQueryParam("type", request.Type);
            if (request.PackageId.HasValue)
                flurlReq.SetQueryParam("package_id", request.PackageId);

            return await client.SendRequestWithJsonAsync<PackageGetDetailResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }


    }
}
