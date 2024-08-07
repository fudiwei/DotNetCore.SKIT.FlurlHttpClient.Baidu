using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty
{
    using SKIT.FlurlHttpClient;

    public static class BaiduSmartAppThirdPartyClientExecuteFileExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /file/2.0/smartapp/upload/image 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://smartprogram.baidu.com/docs/third/image/upload/ ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FileUploadImageResponse> ExecuteFileUploadImageAsync(this BaiduSmartAppThirdPartyClient client, Models.FileUploadImageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "file", "2.0", "smartapp", "upload", "image")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("type", request.ImageType);

            if (request.ImageFileName is null)
                request.ImageFileName = Guid.NewGuid().ToString("N").ToLower() + ".jpg";

            if (request.ImageFileContentType is null)
                request.ImageFileContentType = MimeTypes.GetMimeMapping(request.ImageFileName);

            using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: request.ImageFileName, fileBytes: request.ImageFileBytes, fileContentType: request.ImageFileContentType, formDataName: "multipartFile");
            httpContent.Add(new StringContent(request.ImageType.ToString(), Encoding.UTF8), "type");
            return await client.SendFlurlRequestAsync<Models.FileUploadImageResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
