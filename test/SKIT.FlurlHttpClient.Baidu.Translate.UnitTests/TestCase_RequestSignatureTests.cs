using System;
using Xunit;

namespace SKIT.FlurlHttpClient.Baidu.Translate.UnitTests
{
    public partial class TestCase_RequestSignatureTests
    {
        [Fact(DisplayName = "测试用例：生成 [POST] /trans/vip/translate 接口的请求签名")]
        public void TestTranslateVipTranslateRequestSignature()
        {
            using var client = new BaiduTranslateClient("2015063000000001", "12345678");
            var req = new Models.TranslateVipTranslateRequest()
            {
                QueryString = "apple",
                From = "en",
                To = "zh",
                Salt = "1435660288"
            };

            string expectedSign = "f89f9594663708c1605f3d736d01d2d4";
            string actualSign = req.GenerateSignature(client.Credentials)!;
            Assert.Equal(expectedSign, actualSign, ignoreCase: false);
        }

        [Fact(DisplayName = "测试用例：生成 [POST] /trans/vip/fieldtranslate 接口的请求签名")]
        public void TestTranslateVipFieldTranslateRequestSignature()
        {
            using var client = new BaiduTranslateClient("2015063000000001", "12345678");
            var req = new Models.TranslateVipFieldTranslateRequest()
            {
                QueryString = "apple",
                From = "en",
                To = "zh",
                Salt = "1435660288",
                Domain = "medicine"
            };

            string expectedSign = "f89f9594663708c1605f3d736d01d2d4";
            string actualSign = req.GenerateSignature(client.Credentials)!;
            Assert.Equal(expectedSign, actualSign, ignoreCase: false);
        }

        [Fact(DisplayName = "测试用例：生成 [POST] /trans/vip/doccount 接口的请求签名")]
        public void TestTranslateVipDocumentCountRequestSignature()
        {
            using var client = new BaiduTranslateClient("2015063000000001", "12345678");
            var req = new Models.TranslateVipDocumentCountRequest()
            {
                FileType = "txt",
                FileBytes = Convert.FromBase64String("ZG9jY291bnQ="),
                From = "en",
                To = "zh",
                Timestamp = 1435660288
            };

            string expectedSign = "e961ce98f11d55bf60e7adb7724d4566";
            string actualSign = req.GenerateSignature(client.Credentials)!;
            Assert.Equal(expectedSign, actualSign, ignoreCase: false);
        }

        [Fact(DisplayName = "测试用例：生成 [POST] /trans/vip/language 接口的请求签名")]
        public void TestTranslateVipLanguageRequestSignature()
        {
            using var client = new BaiduTranslateClient("2015063000000001", "12345678");
            var req = new Models.TranslateVipLanguageRequest()
            {
                QueryString = "apple",
                Salt = "1435660288"
            };

            string expectedSign = "f89f9594663708c1605f3d736d01d2d4";
            string actualSign = req.GenerateSignature(client.Credentials)!;
            Assert.Equal(expectedSign, actualSign, ignoreCase: false);
        }
    }
}
