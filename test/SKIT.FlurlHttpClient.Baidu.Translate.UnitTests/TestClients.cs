namespace SKIT.FlurlHttpClient.Baidu.Translate.UnitTests
{
    internal class TestClients
    {
        static TestClients()
        {
            Instance = new BaiduTranslateClient(new BaiduTranslateClientOptions()
            {
                AppId = TestConfigs.BaiduTranslateAppId,
                AppSecret = TestConfigs.BaiduTranslateAppSecret
            });
        }

        public static readonly BaiduTranslateClient Instance;
    }
}
