namespace SKIT.FlurlHttpClient.Baidu.SmartApp.UnitTests
{
    using SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi;
    using SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty;

    internal class ITClients
    {
        public static BaiduSmartAppOpenApiClient CreateOpenApiInstance()
        {
            return new BaiduSmartAppOpenApiClient(new BaiduSmartAppOpenApiClientOptions()
            {
                AppId = ITConfigs.Credentials_AppId,
                AppKey = ITConfigs.Credentials_AppKey,
                AppSecret = ITConfigs.Credentials_AppSecret
            });
        }

        public static BaiduSmartAppThirdPartyClient CreateThirdPartyInstance()
        {
            return new BaiduSmartAppThirdPartyClient(new BaiduSmartAppThirdPartyClientOptions()
            {
                AppId = ITConfigs.Credentials_AppId,
                AppKey = ITConfigs.Credentials_AppKey,
                AppSecret = ITConfigs.Credentials_AppSecret
            });
        }
    }
}
