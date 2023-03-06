namespace SKIT.FlurlHttpClient.Baidu.Push.UnitTests
{
    internal class TestClients
    {
        static TestClients()
        {
            Instance = new BaiduPushClient(new BaiduPushClientOptions()
            {
                ApiKey = TestConfigs.BaiduPushApiKey,
                SecretKey = TestConfigs.BaiduPushApiSecretKey
            });
        }

        public static readonly BaiduPushClient Instance;
    }
}
