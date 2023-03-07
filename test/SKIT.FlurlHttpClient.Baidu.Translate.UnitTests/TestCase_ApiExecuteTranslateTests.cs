using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Baidu.Translate.UnitTests
{
    public class TestCase_ApiExecuteTranslateTests
    {
        [Fact(DisplayName = "测试用例：调用 API [POST] /trans/vip/translate")]
        public async Task TestExecuteTranslateVipTranslate()
        {
            var request = new Models.TranslateVipTranslateRequest()
            {
                QueryString = "Hello, World!",
                From = "en",
                To = "zh"
            };
            var response = await TestClients.Instance.ExecuteTranslateVipTranslateAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.Equal("en", response.From);
            Assert.Equal("zh", response.To);
            Assert.NotNull(response.ResultList);
        }
    }
}
