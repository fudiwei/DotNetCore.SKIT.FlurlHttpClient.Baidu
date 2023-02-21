using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty
{
    public static class SmartAppThirdPartyClientExecuteFileExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /file/2.0/smartapp/upload/image 接口。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/image/upload/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FileUploadImageResponse> ExecuteFileUploadImageAsync(this BaiduSmartAppThirdPartyClient client, Models.FileUploadImageRequest request, CancellationToken cancellationToken = default)
        {
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "file", "2.0", "smartapp", "upload", "image")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.ImageFileName == null)
                request.ImageFileName = Guid.NewGuid().ToString("N").ToLower() + ".jpg";

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.ImageFileName, fileBytes: request.ImageFileBytes, fileContentType: "image/jpeg", formDataName: "multipartFile");
            httpContent.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(request.ImageType.ToString())), "type");

            return await client.SendRequestAsync<Models.FileUploadImageResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }
    }
}
