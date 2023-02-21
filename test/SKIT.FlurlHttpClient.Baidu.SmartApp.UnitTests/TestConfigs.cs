using System;
using System.IO;
using System.Text.Json;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.UnitTests
{
    internal class TestConfigs
    {
        static TestConfigs()
        {
            // NOTICE:  请在项目根目录下按照 appsettings.json 的格式新建 appsettings.local.json 填入测试参数。
            // WARNING: 请在 DEBUG 模式下运行测试用例。
            // WARNING: 敏感信息请不要提交到 git！

            try
            {
                using var stream = File.OpenRead("appsettings.local.json");
                using var json = JsonDocument.Parse(stream);

                var config = json.RootElement.GetProperty("TestConfig");
                BaiduSmartAppId = config.GetProperty("AppId").GetString()!;
                BaiduSmartAppKey = config.GetProperty("AppKey").GetString()!;
                BaiduSmartAppSecret = config.GetProperty("AppSecret").GetString()!;
                BaiduSmartAppAccessToken = config.GetProperty("AccessToken").GetString()!;

                WorkDirectoryForSdk = json.RootElement.GetProperty("WorkDirectoryForSdk").GetString()!;
                WorkDirectoryForTest = json.RootElement.GetProperty("WorkDirectoryForTest").GetString()!;
            }
            catch (Exception ex)
            {
                throw new Exception("加载配置文件 appsettings.local.json 失败，请查看 `InnerException` 了解具体失败原因", ex);
            }
        }

        public static readonly string BaiduSmartAppId;
        public static readonly string BaiduSmartAppKey;
        public static readonly string BaiduSmartAppSecret;
        public static readonly string BaiduSmartAppAccessToken;

        public static readonly string WorkDirectoryForSdk;
        public static readonly string WorkDirectoryForTest;
    }
}
