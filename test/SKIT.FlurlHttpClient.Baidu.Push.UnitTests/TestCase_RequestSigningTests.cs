using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Xunit;

namespace SKIT.FlurlHttpClient.Baidu.Push.UnitTests
{
    public partial class TestCase_RequestSigningTests
    {
        // 此处测试的 API Key/SecretKey 是随机生成的，仅供执行请求签名相关的单元测试，不能用于调用百度云推送 API。
        private const string MOCK_ENDPOINTS = BaiduPushEndpoints.DEFAULT;
        private const string MOCK_API_KEY = "123456789";
        private const string MOCK_API_SECRET_KEY = "abcdefghi";

        private const string RESPONSE_HEADER_NAME_QUERY = "X-Request-Query";
        private const string RESPONSE_HEADER_NAME_BODY = "X-Request-Body";

        [Fact(DisplayName = "测试用例：生成 GET 请求签名")]
        public async Task TestGetRequestSignature()
        {
            using var client = CreateMockClient();
            var req = new Models.AppQueryTagsRequest() { TagName = "TAG" };
            var res = await client.ExecuteAppQueryTagsAsync(req);

            var queryParams = new QueryParamCollection(res.GetRawHeaders().GetFirstValueOrEmpty(RESPONSE_HEADER_NAME_QUERY));
            string expectedSign = Utilities.MD5Utility.Hash(Utilities.QuirksUrlEncoder.Encode(
                $"GET{MOCK_ENDPOINTS}/app/query_tags" +
                $"apikey={(string)queryParams.GetAll("apikey").Single()}" +
                $"expires={(string)queryParams.GetAll("expires").Single()}" +
                $"tag={req.TagName}" +
                $"timestamp={(string)queryParams.GetAll("timestamp").Single()}" +
                $"{MOCK_API_SECRET_KEY}"
            ))!;
            string actualSign = (string)queryParams.GetAll("sign").Single();
            Assert.Equal(expectedSign, actualSign, ignoreCase: true);
        }

        [Fact(DisplayName = "测试用例：生成 POST 请求签名")]
        public async Task TestPostRequestSignature()
        {
            using var client = CreateMockClient();
            var req = new Models.AppCreateTagRequest() { TagName = "TAG" };
            var res = await client.ExecuteAppCreateTagAsync(req);

            var queryParams = new QueryParamCollection(res.GetRawHeaders().GetFirstValueOrEmpty(RESPONSE_HEADER_NAME_BODY));
            string expectedSign = Utilities.MD5Utility.Hash(Utilities.QuirksUrlEncoder.Encode(
                $"POST{MOCK_ENDPOINTS}/app/create_tag" +
                $"apikey={(string)queryParams.GetAll("apikey").Single()}" +
                $"expires={(string)queryParams.GetAll("expires").Single()}" +
                $"tag={req.TagName}" +
                $"timestamp={(string)queryParams.GetAll("timestamp").Single()}" +
                $"{MOCK_API_SECRET_KEY}"
            ))!;
            string actualSign = (string)queryParams.GetAll("sign").Single();
            Assert.Equal(expectedSign, actualSign, ignoreCase: true);
        }
    }

    partial class TestCase_RequestSigningTests
    {
        public class MockHttpClient : HttpClient
        {
            public MockHttpClient()
                : base(new MockHttpMessageHandler(new HttpClientHandler()))
            {
            }
        }

        public class MockHttpMessageHandler : DelegatingHandler
        {
            public MockHttpMessageHandler(HttpMessageHandler innerHandler)
                : base(innerHandler)
            {
            }

            protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                var resp = new HttpResponseMessage
                {
                    RequestMessage = request,
                    StatusCode = HttpStatusCode.NoContent,
                    Content = new ByteArrayContent(Array.Empty<byte>()),
                };
                resp.Headers.TryAddWithoutValidation("Content-Length", (0).ToString());
                resp.Headers.TryAddWithoutValidation(RESPONSE_HEADER_NAME_QUERY, request.RequestUri!.Query);
                resp.Headers.TryAddWithoutValidation(RESPONSE_HEADER_NAME_BODY, request.Content is not null ? await request.Content.ReadAsStringAsync()! : string.Empty);
                return resp;
            }
        }

        private static BaiduPushClient CreateMockClient()
        {
            var client = new BaiduPushClient(new BaiduPushClientOptions()
            {
                ApiKey = MOCK_API_KEY,
                SecretKey = MOCK_API_SECRET_KEY
            }, new MockHttpClient());
            return client;
        }
    }
}
