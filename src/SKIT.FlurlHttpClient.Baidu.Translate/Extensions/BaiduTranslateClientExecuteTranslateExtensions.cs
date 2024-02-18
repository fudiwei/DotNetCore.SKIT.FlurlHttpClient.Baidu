using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Baidu.Translate
{
    public static class BaiduTranslateClientExecuteTranslateExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /trans/vip/translate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.fanyi.baidu.com/doc/21 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TranslateVipTranslateResponse> ExecuteTranslateVipTranslateAsync(this BaiduTranslateClient client, Models.TranslateVipTranslateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "trans", "vip", "translate");

            return await client.SendFlurlRequestAsFormUrlEncodedAsync<Models.TranslateVipTranslateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /trans/vip/fieldtranslate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.fanyi.baidu.com/doc/22 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TranslateVipFieldTranslateResponse> ExecuteTranslateVipFieldTranslateAsync(this BaiduTranslateClient client, Models.TranslateVipFieldTranslateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "trans", "vip", "fieldtranslate");

            return await client.SendFlurlRequestAsFormUrlEncodedAsync<Models.TranslateVipFieldTranslateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /trans/vip/language 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.fanyi.baidu.com/doc/24 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TranslateVipLanguageResponse> ExecuteTranslateVipLanguageAsync(this BaiduTranslateClient client, Models.TranslateVipLanguageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "trans", "vip", "language");

            return await client.SendFlurlRequestAsFormUrlEncodedAsync<Models.TranslateVipLanguageResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /trans/vip/doccount 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.fanyi.baidu.com/doc/27 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TranslateVipDocumentCountResponse> ExecuteTranslateVipDocumentCountAsync(this BaiduTranslateClient client, Models.TranslateVipDocumentCountRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            string? fileContentType = null;
            switch (request.FileType)
            {
                case "doc":
                    {
                        fileContentType = "application/msword";
                        request.FileName = request.FileName ?? "file.doc";
                    }
                    break;

                case "docx":
                    {
                        fileContentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                        request.FileName = request.FileName ?? "file.docx";
                    }
                    break;

                case "xls":
                    {
                        fileContentType = "application/vnd.ms-excel";
                        request.FileName = request.FileName ?? "file.xls";
                    }
                    break;

                case "xlsx":
                    {
                        fileContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                        request.FileName = request.FileName ?? "file.xlsx";
                    }
                    break;

                case "ppt":
                    {
                        fileContentType = "application/vnd.ms-powerpoint";
                        request.FileName = request.FileName ?? "file.ppt";
                    }
                    break;

                case "pptx":
                    {
                        fileContentType = "application/vnd.openxmlformats-officedocument.presentationml.presentation";
                        request.FileName = request.FileName ?? "file.pptx";
                    }
                    break;

                case "pdf":
                    {
                        fileContentType = "application/pdf";
                        request.FileName = request.FileName ?? "file.pdf";
                    }
                    break;

                case "xml":
                    {
                        fileContentType = "text/xml";
                        request.FileName = request.FileName ?? "file.xml";
                    }
                    break;

                case "htm":
                    {
                        fileContentType = "text/html";
                        request.FileName = request.FileName ?? "file.htm";
                    }
                    break;

                case "html":
                    {
                        fileContentType = "text/html";
                        request.FileName = request.FileName ?? "file.html";
                    }
                    break;

                case "txt":
                    {
                        fileContentType = "text/plain";
                        request.FileName = request.FileName ?? "file.txt";
                    }
                    break;
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "trans", "vip", "doccount");

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.FileName!, fileBytes: request.FileBytes, fileContentType: fileContentType!, formDataName: "file");
            httpContent.Add(new StringContent(request.AppId!, Encoding.UTF8), "appid");
            httpContent.Add(new StringContent(request.From, Encoding.UTF8), "from");
            httpContent.Add(new StringContent(request.Timestamp!.Value.ToString(), Encoding.UTF8), "timestamp");
            httpContent.Add(new StringContent(request.To, Encoding.UTF8), "to");
            httpContent.Add(new StringContent(request.FileType!, Encoding.UTF8), "type");
            httpContent.Add(new StringContent(request.Signature!, Encoding.UTF8), "sign");
            return await client.SendFlurlRequestAsync<Models.TranslateVipDocumentCountResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /trans/vip/doctrans 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.fanyi.baidu.com/doc/27 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TranslateVipDocumentTranslateResponse> ExecuteTranslateVipDocumentTranslateAsync(this BaiduTranslateClient client, Models.TranslateVipDocumentTranslateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            string? fileContentType = null;
            switch (request.FileType)
            {
                case "doc":
                    {
                        fileContentType = "application/msword";
                        request.FileName = request.FileName ?? "file.doc";
                    }
                    break;

                case "docx":
                    {
                        fileContentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                        request.FileName = request.FileName ?? "file.docx";
                    }
                    break;

                case "xls":
                    {
                        fileContentType = "application/vnd.ms-excel";
                        request.FileName = request.FileName ?? "file.xls";
                    }
                    break;

                case "xlsx":
                    {
                        fileContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                        request.FileName = request.FileName ?? "file.xlsx";
                    }
                    break;

                case "ppt":
                    {
                        fileContentType = "application/vnd.ms-powerpoint";
                        request.FileName = request.FileName ?? "file.ppt";
                    }
                    break;

                case "pptx":
                    {
                        fileContentType = "application/vnd.openxmlformats-officedocument.presentationml.presentation";
                        request.FileName = request.FileName ?? "file.pptx";
                    }
                    break;

                case "pdf":
                    {
                        fileContentType = "application/pdf";
                        request.FileName = request.FileName ?? "file.pdf";
                    }
                    break;

                case "xml":
                    {
                        fileContentType = "text/xml";
                        request.FileName = request.FileName ?? "file.xml";
                    }
                    break;

                case "htm":
                    {
                        fileContentType = "text/html";
                        request.FileName = request.FileName ?? "file.htm";
                    }
                    break;

                case "html":
                    {
                        fileContentType = "text/html";
                        request.FileName = request.FileName ?? "file.html";
                    }
                    break;

                case "txt":
                    {
                        fileContentType = "text/plain";
                        request.FileName = request.FileName ?? "file.txt";
                    }
                    break;
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "trans", "vip", "doctrans");

            if (request.FileBytes is null)
            {
                return await client.SendFlurlRequestAsFormUrlEncodedAsync<Models.TranslateVipDocumentTranslateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.FileName!, fileBytes: request.FileBytes, fileContentType: fileContentType!, formDataName: "file");
                httpContent.Add(new StringContent(request.AppId!, Encoding.UTF8), "appid");
                httpContent.Add(new StringContent(request.FileId ?? string.Empty, Encoding.UTF8), "fileId");
                httpContent.Add(new StringContent(request.From, Encoding.UTF8), "from");
                httpContent.Add(new StringContent(request.OutputType ?? string.Empty, Encoding.UTF8), "outPutType");
                httpContent.Add(new StringContent(request.Timestamp!.Value.ToString(), Encoding.UTF8), "timestamp");
                httpContent.Add(new StringContent(request.To, Encoding.UTF8), "to");
                httpContent.Add(new StringContent(request.FileType!, Encoding.UTF8), "type");
                httpContent.Add(new StringContent(request.Signature!, Encoding.UTF8), "sign");
                return await client.SendFlurlRequestAsync<Models.TranslateVipDocumentTranslateResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// <para>异步调用 [POST] /trans/v2/voicetrans 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.fanyi.baidu.com/doc/25 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TranslateVoiceTranslateV2Response> ExecuteTranslateVoiceTranslateV2Async(this BaiduTranslateClient client, Models.TranslateVoiceTranslateV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "trans", "v2", "voicetrans")
                .WithHeader("X-Appid", request.AppId)
                .WithHeader("X-Timestamp", request.Timestamp)
                .WithHeader("X-Sign", request.Signature);

            return await client.SendFlurlRequestAsJsonAsync<Models.TranslateVoiceTranslateV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /trans/sdk/picture 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.fanyi.baidu.com/doc/26 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TranslateSdkPictureResponse> ExecuteTranslateSdkPictureAsync(this BaiduTranslateClient client, Models.TranslateSdkPictureRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "trans", "sdk", "picture");

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: "image.jpg", fileBytes: request.ImageFileBytes!, fileContentType: "image/jpeg", formDataName: "image");
            httpContent.Add(new StringContent(request.AppId!, Encoding.UTF8), "appid");
            httpContent.Add(new StringContent(request.CUID, Encoding.UTF8), "cuid");
            httpContent.Add(new StringContent(request.From, Encoding.UTF8), "from");
            httpContent.Add(new StringContent(request.MAC, Encoding.UTF8), "mac");
            httpContent.Add(new StringContent(request.PasteType.GetValueOrDefault().ToString(), Encoding.UTF8), "paste");
            httpContent.Add(new StringContent(request.Salt!, Encoding.UTF8), "salt");
            httpContent.Add(new StringContent(request.To, Encoding.UTF8), "to");
            httpContent.Add(new StringContent(request.Version.ToString(), Encoding.UTF8), "version");
            httpContent.Add(new StringContent(request.Signature!, Encoding.UTF8), "sign");
            return await client.SendFlurlRequestAsync<Models.TranslateSdkPictureResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
