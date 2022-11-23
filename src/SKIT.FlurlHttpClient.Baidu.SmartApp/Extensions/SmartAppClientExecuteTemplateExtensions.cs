using Flurl.Http;
using SKIT.FlurlHttpClient.Baidu.SmartApp.Models.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp
{
    public static class SmartAppClientExecuteTemplateExtensions
    {
        /// <summary>
        /// 获取模板草稿列表
        /// <para>异步调用 [GET] rest/2.0/smartapp/template/gettemplatedraftlist 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/template/gettemplatedraftlist </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<GetTemplateDraftListResponse> ExecuteSmartAppTemplateGetTemplateDraftListAsync(this SmartAppThirdPartyClient client, GetTemplateDraftListRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "template", "gettemplatedraftlist")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.Page.HasValue)
                flurlReq.SetQueryParam("page", request.Page.Value);
            if (request.PageSize.HasValue)
                flurlReq.SetQueryParam("page_size", request.PageSize.Value);

            return await client.SendRequestWithJsonAsync<GetTemplateDraftListResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 获取模板列表
        /// <para>异步调用 [GET] rest/2.0/smartapp/template/gettemplatelist 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/template/gettemplatelist </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<GetTemplateListResponse> ExecuteSmartAppTemplateGetTemplateListAsync(this SmartAppThirdPartyClient client, GetTemplateListRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rest", "2.0", "smartapp", "template", "gettemplatelist")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.Page.HasValue)
                flurlReq.SetQueryParam("page", request.Page.Value);
            if (request.PageSize.HasValue)
                flurlReq.SetQueryParam("page_size", request.PageSize.Value);

            return await client.SendRequestWithJsonAsync<GetTemplateListResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 添加草稿至模板
        /// <para>异步调用 [POST] rest/2.0/smartapp/template/addtotemplate 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/template/addtotemplate </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<AddToTemplateResponse> ExecuteSmartAppTemplateAddToTemplateAsync(this SmartAppThirdPartyClient client, AddToTemplateRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "template", "addtotemplate")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("draft_id", request.DraftId)
                .SetQueryParam("user_desc", request.UserDesc);

            return await client.SendRequestWithJsonAsync<AddToTemplateResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 删除模板
        /// <para>异步调用 [POST] rest/2.0/smartapp/template/deltemplate 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/template/deltemplate </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<DelTemplateResponse> ExecuteSmartAppTemplateDelTemplateAsync(this SmartAppThirdPartyClient client, DelTemplateRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rest", "2.0", "smartapp", "template", "addtotemplate")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("template_id", request.TemplateId);

            return await client.SendRequestWithJsonAsync<DelTemplateResponse>(flurlReq, data: null, cancellationToken: cancellationToken);
        }

    }
}
