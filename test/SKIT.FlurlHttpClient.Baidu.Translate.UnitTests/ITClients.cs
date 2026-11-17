namespace SKIT.FlurlHttpClient.Baidu.Translate.UnitTests
{
    internal class ITClients
    {
        public static BaiduTranslateClient CreateInstance()
        {
            return new BaiduTranslateClient(new BaiduTranslateClientOptions()
            {
                AppId = ITConfigs.Credentials_AppId,
                AppSecret = ITConfigs.Credentials_AppSecret
            });
        }
    }
}
