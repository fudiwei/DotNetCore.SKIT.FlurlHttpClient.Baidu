namespace SKIT.FlurlHttpClient.Baidu.SmartApp.UnitTests
{
    using SKIT.FlurlHttpClient.Tools.CodeAnalyzer;

    public class CodeAnalysis
    {
        // NOTICE:
        //   如果在 Visual Studio 打开时遇到 “缺少 SKIT.FlurlHttpClient.Tools.CodeAnalyzer 包” 的错误，
        //   请参考此 Issue：https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient/issues/8

        private readonly ITestOutputHelper _outputHelper;

        public CodeAnalysis(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact(DisplayName = "代码分析：类型声明")]
        public void CodeAnalysis_TypeDeclaration()
        {
            // NOTICE:
            //   如果 Visual Studio 遇到 “缺少 SKIT.FlurlHttpClient.Tools.CodeAnalyzer 包” 的错误，
            //   请参考此 Issue：https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient/issues/8

            Assert.Multiple(() =>
            {
                var options = TypeDeclarationAnalyzerOptions.LoadFromClient(typeof(ExtendedSDK.OpenApi.BaiduSmartAppOpenApiClient));
                options.ReportOnMissingSDKModels = true;
                options.ReportOnMissingSDKMethods = true;
                options.ReportOnMissingSDKWebhooks = true;

                var analyzer = new TypeDeclarationAnalyzer(options);

                var issues = analyzer.Analyze();
#if DEBUG
                if (issues.Count > 0)
                {
                    foreach (var issue in issues)
                        _outputHelper.WriteLine(issue.ToString());
                }
#endif
                Assert.Empty(issues);
            });

            Assert.Multiple(() =>
            {
                var options = TypeDeclarationAnalyzerOptions.LoadFromClient(typeof(ExtendedSDK.ThirdParty.BaiduSmartAppThirdPartyClient));
                options.ReportOnMissingSDKModels = true;
                options.ReportOnMissingSDKMethods = true;
                options.ReportOnMissingSDKWebhooks = true;

                var analyzer = new TypeDeclarationAnalyzer(options);

                var issues = analyzer.Analyze();
#if DEBUG
                if (issues.Count > 0)
                {
                    foreach (var issue in issues)
                        _outputHelper.WriteLine(issue.ToString());
                }
#endif
                Assert.Empty(issues);
            });
        }

        [Fact(DisplayName = "代码分析：静态文件")]
        public void CodeAnalysis_StaticFile()
        {
            Assert.Multiple(() =>
            {
                string workDir = Environment.CurrentDirectory;
                string projDir = Path.Combine(workDir, "../../../../../");

                var options = StaticFileAnalyzerOptions.LoadFromClient(typeof(ExtendedSDK.OpenApi.BaiduSmartAppOpenApiClient));
                options.ProjectRootPath = Path.Combine(projDir, "./src/SKIT.FlurlHttpClient.Baidu.SmartApp/ExtendedSDK/OpenApi/");
                options.ReportOnMissingSDKModelsCodes = true;
                options.ReportOnMissingSDKModelsFixtures = true;
                options.ReportOnMissingSDKMethodsCodes = true;
                options.ReportOnMissingSDKWebhooksCodes = true;
                options.ReportOnMissingSDKWebhooksFixtures = true;

                var analyzer = new StaticFileAnalyzer(options);

                var issues = analyzer.Analyze();
#if DEBUG
                if (issues.Count > 0)
                {
                    foreach (var issue in issues)
                        _outputHelper.WriteLine(issue.ToString());
                }
#endif
                Assert.Empty(issues);
            });

            Assert.Multiple(() =>
            {
                string workDir = Environment.CurrentDirectory;
                string projDir = Path.Combine(workDir, "../../../../../");

                var options = StaticFileAnalyzerOptions.LoadFromClient(typeof(ExtendedSDK.ThirdParty.BaiduSmartAppThirdPartyClient));
                options.ProjectRootPath = Path.Combine(projDir, "./src/SKIT.FlurlHttpClient.Baidu.SmartApp/ExtendedSDK/ThirdParty/");
                options.ReportOnMissingSDKModelsCodes = true;
                options.ReportOnMissingSDKModelsFixtures = true;
                options.ReportOnMissingSDKMethodsCodes = true;
                options.ReportOnMissingSDKWebhooksCodes = true;
                options.ReportOnMissingSDKWebhooksFixtures = true;

                var analyzer = new StaticFileAnalyzer(options);

                var issues = analyzer.Analyze();
#if DEBUG
                if (issues.Count > 0)
                {
                    foreach (var issue in issues)
                        _outputHelper.WriteLine(issue.ToString());
                }
#endif
                Assert.Empty(issues);
            });
        }
    }
}
