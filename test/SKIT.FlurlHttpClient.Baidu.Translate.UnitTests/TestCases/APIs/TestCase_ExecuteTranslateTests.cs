namespace SKIT.FlurlHttpClient.Baidu.Translate.UnitTests.TestCases.APIs
{
    public class TestCase_ExecuteTranslateTests
    {
        [Fact(DisplayName = "测试用例：调用 API（[POST] /trans/vip/translate）")]
        public async Task TestExecuteTranslateVipTranslate()
        {
            using var client = ITClients.CreateInstance();
            var request = new Models.TranslateVipTranslateRequest()
            {
                QueryString = "Hello, World!",
                From = "en",
                To = "zh"
            };
            var response = await client.ExecuteTranslateVipTranslateAsync(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.Equal("en", response.From);
            Assert.Equal("zh", response.To);
            Assert.NotNull(response.ResultList);
        }
    }
}
