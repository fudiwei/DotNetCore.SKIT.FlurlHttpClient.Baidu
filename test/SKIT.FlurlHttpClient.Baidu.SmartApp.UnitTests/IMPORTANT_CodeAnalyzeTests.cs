using System;
using System.IO;
using System.Reflection;
using SKIT.FlurlHttpClient.Tools.CodeAnalyzer;
using Xunit;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.UnitTests
{
    using SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi;
    using SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty;

    public class CodeAnalyzeTests
    {
        [Fact(DisplayName = "代码质量分析")]
        public void CodeAnalyze()
        {
            // NOTICE:
            //   如果 Visual Studio 遇到 “缺少 SKIT.FlurlHttpClient.Tools.CodeAnalyzer 包” 的错误，
            //   请参考此 Issue：https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient/issues/8

            Assert.Null(Record.Exception(() =>
            {
                var options = new TypeDeclarationAnalyzerOptions()
                {
                    SdkAssembly = Assembly.GetAssembly(typeof(BaiduSmartAppOpenApiClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models",
                    SdkExecutingExtensionDeclarationNamespace = "SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi",
                    SdkWebhookEventDeclarationNamespace = "SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Events",
                    ThrowOnNotFoundRequestModelTypes = true,
                    ThrowOnNotFoundResponseModelTypes = true,
                    ThrowOnNotFoundExecutingExtensionTypes = true,
                    ThrowOnNotFoundWebhookEventTypes = true
                };
                new TypeDeclarationAnalyzer(options).AssertNoIssues();
            }));

            Assert.Null(Record.Exception(() =>
            {
                string workdir = Environment.CurrentDirectory;
                string projdir = Path.Combine(workdir, "../../../../../");

                var options = new SourceFileAnalyzerOptions()
                {
                    SdkAssembly = Assembly.GetAssembly(typeof(BaiduSmartAppOpenApiClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models",
                    SdkWebhookEventDeclarationNamespace = "SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Events",
                    ProjectSourceRootDirectory = Path.Combine(projdir, "./src/SKIT.FlurlHttpClient.Baidu.SmartApp/"),
                    ProjectSourceRequestModelClassCodeSubDirectory = "ExtendedSDK/OpenApi/Models/",
                    ProjectSourceResponseModelClassCodeSubDirectory = "ExtendedSDK/OpenApi/Models/",
                    ProjectSourceExecutingExtensionClassCodeSubDirectory = "ExtendedSDK/OpenApi/Extensions/",
                    ProjectSourceWebhookEventClassCodeSubDirectory = "ExtendedSDK/OpenApi/Events/",
                    ProjectTestRootDirectory = Path.Combine(projdir, "./test/SKIT.FlurlHttpClient.Baidu.SmartApp.UnitTests/"),
                    ProjectTestRequestModelSerializationSampleSubDirectory = "ModelSamples/OpenApi/",
                    ProjectTestResponseModelSerializationSampleSubDirectory = "ModelSamples/OpenApi/",
                    ProjectTestWebhookEventSerializationSampleSubDirectory = "EventSamples/OpenApi/",
                    ThrowOnNotFoundRequestModelClassCodeFiles = true,
                    ThrowOnNotFoundResponseModelClassCodeFiles = true,
                    ThrowOnNotFoundExecutingExtensionClassCodeFiles = true,
                    ThrowOnNotFoundWebhookEventClassCodeFiles = true,
                    ThrowOnNotFoundRequestModelSerializationSampleFiles = true,
                    ThrowOnNotFoundResponseModelSerializationSampleFiles = true,
                    ThrowOnNotFoundWebhookEventSerializationSampleFiles = true
                };
                new SourceFileAnalyzer(options).AssertNoIssues();
            }));


            Assert.Null(Record.Exception(() =>
            {
                var options = new TypeDeclarationAnalyzerOptions()
                {
                    SdkAssembly = Assembly.GetAssembly(typeof(BaiduSmartAppThirdPartyClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models",
                    SdkExecutingExtensionDeclarationNamespace = "SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty",
                    SdkWebhookEventDeclarationNamespace = "SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Events",
                    ThrowOnNotFoundRequestModelTypes = true,
                    ThrowOnNotFoundResponseModelTypes = true,
                    ThrowOnNotFoundExecutingExtensionTypes = true,
                    ThrowOnNotFoundWebhookEventTypes = true
                };
                new TypeDeclarationAnalyzer(options).AssertNoIssues();
            }));

            Assert.Null(Record.Exception(() =>
            {
                string workdir = Environment.CurrentDirectory;
                string projdir = Path.Combine(workdir, "../../../../../");

                var options = new SourceFileAnalyzerOptions()
                {
                    SdkAssembly = Assembly.GetAssembly(typeof(BaiduSmartAppThirdPartyClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models",
                    SdkWebhookEventDeclarationNamespace = "SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Events",
                    ProjectSourceRootDirectory = Path.Combine(projdir, "./src/SKIT.FlurlHttpClient.Baidu.SmartApp/"),
                    ProjectSourceRequestModelClassCodeSubDirectory = "ExtendedSDK/ThirdParty/Models/",
                    ProjectSourceResponseModelClassCodeSubDirectory = "ExtendedSDK/ThirdParty/Models/",
                    ProjectSourceExecutingExtensionClassCodeSubDirectory = "ExtendedSDK/ThirdParty/Extensions/",
                    ProjectSourceWebhookEventClassCodeSubDirectory = "ExtendedSDK/ThirdParty/Events/",
                    ProjectTestRootDirectory = Path.Combine(projdir, "./test/SKIT.FlurlHttpClient.Baidu.SmartApp.UnitTests/"),
                    ProjectTestRequestModelSerializationSampleSubDirectory = "ModelSamples/ThirdParty/",
                    ProjectTestResponseModelSerializationSampleSubDirectory = "ModelSamples/ThirdParty/",
                    ProjectTestWebhookEventSerializationSampleSubDirectory = "EventSamples/ThirdParty/",
                    ThrowOnNotFoundRequestModelClassCodeFiles = true,
                    ThrowOnNotFoundResponseModelClassCodeFiles = true,
                    ThrowOnNotFoundExecutingExtensionClassCodeFiles = true,
                    ThrowOnNotFoundWebhookEventClassCodeFiles = true,
                    ThrowOnNotFoundRequestModelSerializationSampleFiles = true,
                    ThrowOnNotFoundResponseModelSerializationSampleFiles = true,
                    ThrowOnNotFoundWebhookEventSerializationSampleFiles = true
                };
                new SourceFileAnalyzer(options).AssertNoIssues();
            }));
        }
    }
}
