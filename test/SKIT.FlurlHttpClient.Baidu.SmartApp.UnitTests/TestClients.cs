namespace SKIT.FlurlHttpClient.Baidu.SmartApp.UnitTests
{
    using SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi;
    using SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty;

    internal class TestClients
    {
        static TestClients()
        {
            OpenApiInstance = new BaiduSmartAppOpenApiClient(new BaiduSmartAppOpenApiClientOptions()
            {
                AppId = TestConfigs.BaiduSmartAppId,
                AppKey = TestConfigs.BaiduSmartAppKey,
                AppSecret = TestConfigs.BaiduSmartAppSecret
            });

            ThirdPartyInstance = new BaiduSmartAppThirdPartyClient(new BaiduSmartAppThirdPartyClientOptions()
            {
                AppId = TestConfigs.BaiduSmartAppId,
                AppKey = TestConfigs.BaiduSmartAppKey,
                AppSecret = TestConfigs.BaiduSmartAppSecret
            });
        }

        public static readonly BaiduSmartAppOpenApiClient OpenApiInstance;

        public static readonly BaiduSmartAppThirdPartyClient ThirdPartyInstance;
    }
}
