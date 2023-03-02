using SKIT.FlurlHttpClient.Tools.CodeAnalyzer;
using Xunit;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.UnitTests
{
    public class TestCase_CodeReview
    {
        [Fact(DisplayName = "测试用例：代码质量分析")]
        public void TestCodeAnalyzer()
        {
            Assert.Null(Record.Exception(() =>
            {
                CodeAnalyzerOptions options = new CodeAnalyzerOptions()
                {
                    AssemblyName = "SKIT.FlurlHttpClient.Baidu.SmartApp",
                    TargetSdkApiModelNamespaceUnderAssemblyIdentifier = "SDK.OpenApi.Models",
                    TargetSdkApiEventNamespaceUnderAssemblyIdentifier = "SDK.OpenApi.Events",
                    TargetSdkApiMethodNamespaceUnderAssemblyIdentifier = "SDK.OpenApi",
                    WorkDirectoryForSourceCode = TestConfigs.WorkDirectoryForSdk,
                    WorkDirectoryForTestSample = TestConfigs.WorkDirectoryForTest,
                    WorkSubDirectoryForApiMethods = "SDK/OpenApi/Extensions",
                    WorkSubDirectoryForApiModels = "SDK/OpenApi/Models",
                    WorkSubDirectoryForApiEvents = "SDK/OpenApi/Events",
                    WorkSubDirectoryForApiModelSamples = "ModelSamples/OpenApi",
                    WorkSubDirectoryForApiEventSamples = "EventSamples/OpenApi"
                };
                CodeAnalyzer analyzer = new CodeAnalyzer(options);
                analyzer.Start();
                analyzer.Assert();
                analyzer.Flush();
            }));

            Assert.Null(Record.Exception(() =>
            {
                CodeAnalyzerOptions options = new CodeAnalyzerOptions()
                {
                    AssemblyName = "SKIT.FlurlHttpClient.Baidu.SmartApp",
                    TargetSdkApiModelNamespaceUnderAssemblyIdentifier = "SDK.ThirdParty.Models",
                    TargetSdkApiEventNamespaceUnderAssemblyIdentifier = "SDK.ThirdParty.Events",
                    TargetSdkApiMethodNamespaceUnderAssemblyIdentifier = "SDK.ThirdParty",
                    WorkDirectoryForSourceCode = TestConfigs.WorkDirectoryForSdk,
                    WorkDirectoryForTestSample = TestConfigs.WorkDirectoryForTest,
                    WorkSubDirectoryForApiMethods = "SDK/ThirdParty/Extensions",
                    WorkSubDirectoryForApiModels = "SDK/ThirdParty/Models",
                    WorkSubDirectoryForApiEvents = "SDK/ThirdParty/Events",
                    WorkSubDirectoryForApiModelSamples = "ModelSamples/ThirdParty",
                    WorkSubDirectoryForApiEventSamples = "EventSamples/ThirdParty"
                };
                CodeAnalyzer analyzer = new CodeAnalyzer(options);
                analyzer.Start();
                analyzer.Assert();
                analyzer.Flush();
            }));
        }
    }
}
