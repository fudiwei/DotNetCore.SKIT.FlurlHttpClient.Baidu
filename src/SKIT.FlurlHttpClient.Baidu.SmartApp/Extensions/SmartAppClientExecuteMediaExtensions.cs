using Flurl.Http;
using Flurl.Http.Content;
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
    public static class SmartAppClientExecuteMediaExtensions
    {
        /// <summary>
        /// 图片上传
        /// <para>异步调用 [POST] file/2.0/smartapp/upload/image 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/image/upload </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<UploadImageResponse> ExecuteSmartAppUploadImageAsync(this SmartAppThirdPartyClient client, UploadImageRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "file", "2.0", "smartapp", "upload", "image")
                .SetQueryParam("access_token", request.AccessToken);

            var content = new MultipartFormDataContent
            {
                new FileContent(request.FilePath, 1024),
                new StringContent($"type={request.Type}")
            };

            return await client.SendRequestAsync<UploadImageResponse>(flurlReq, content, cancellationToken: cancellationToken);
        }
    }
}
