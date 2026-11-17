namespace SKIT.FlurlHttpClient.Baidu.Push.UnitTests
{
    internal class ITClients
    {
        public static BaiduPushClient CreateInstance()
        {
            return new BaiduPushClient(new BaiduPushClientOptions()
            {
                ApiKey = ITConfigs.Credentials_ApiKey,
                SecretKey = ITConfigs.Credentials_ApiSecretKey
            });
        }
    }
}
