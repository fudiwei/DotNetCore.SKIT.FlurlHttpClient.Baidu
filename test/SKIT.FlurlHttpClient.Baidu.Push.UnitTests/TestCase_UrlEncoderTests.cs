using Xunit;

namespace SKIT.FlurlHttpClient.Baidu.Push.UnitTests
{
    public partial class TestCase_UrlEncoderTests
    {
        [Fact(DisplayName = "测试用例：URL 编码")]
        public void TestUrlEncoderEncoding()
        {
            Assert.Equal("https%3A%2F%2Fapi.tuisong.baidu.com%2Frest%2F3.0", Utilities.UrlEncoder.Encode("https://api.tuisong.baidu.com/rest/3.0"));
            Assert.Equal("%27%21%27+is+an+exclamation+character", Utilities.UrlEncoder.Encode("\'!\' is an exclamation character"));
            Assert.Equal("%27%3A%27+is+a+colon+character", Utilities.UrlEncoder.Encode("\':\' is a colon character"));
            Assert.Equal("%E4%B8%AD%E6%96%87+%E6%B5%8B%E8%AF%95", Utilities.UrlEncoder.Encode("中文 测试"));
        }
    }
}
