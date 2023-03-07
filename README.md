# SKIT.FlurlHttpClient.Baidu

[![Gitee Stars](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Baidu/badge/star.svg?title=Stars)](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Baidu)
[![Gitee Forks](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Baidu/badge/fork.svg?title=Forks)](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Baidu)
[![GitHub Stars](https://img.shields.io/github/stars/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Baidu?logo=github&label=Stars)](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Baidu)
[![GitHub Forks](https://img.shields.io/github/forks/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Baidu?logo=github&label=Forks)](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Baidu)
[![Vistors](https://visitor-badge.laobi.icu/badge?page_id=fudiwei.DotNetCore.SKIT.FlurlHttpClient.Baidu&title=Visitors)](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Baidu)
[![License](https://img.shields.io/github/license/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Baidu?label=License)](https://mit-license.org/)

基于 `Flurl.Http` 的百度 HTTP API SDK，目前已包含百度智能小程序平台、百度地图开放平台、百度翻译开放平台、百度云推送等模块。

> 更多 SKIT.FlurlHttpClient 系列开发工具包请[点此查看](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient)。

---

## 特性

-   基于 `Flurl.Http`，可与 `IHttpClientFactory` 集成。
-   支持 .NET Framework 4.6.1+、.NET Standard 2.0+、.NET Core 2.0+、.NET 5+。
-   支持 Windows / Linux / macOS 多平台部署。
-   支持 `System.Text.Json`（默认）和 `Newtonsoft.Json` 两种序列化方式。
-   强类型接口模型。
-   全异步式编程。
-   提供 SourceLink 调试符号文件。
-   完整、完善、完全的百度 HTTP API 封装。

---

## 模块

|        名称        |                                                                                                                                                                                       NuGet                                                                                                                                                                                        |                  其他                  |
| :----------------: | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: | :------------------------------------: |
| 智能小程序开放平台 |   [![NuGet Version](https://img.shields.io/nuget/v/SKIT.FlurlHttpClient.Baidu.SmartApp.svg?label=NuGet)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Baidu.SmartApp) <br> [![NuGet Download](https://img.shields.io/nuget/dt/SKIT.FlurlHttpClient.Baidu.SmartApp.svg?sanitize=true&label=Downloads)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Baidu.SmartApp)   | [开发文档](./docs/SmartApp/README.md)  |
|    地图开放平台    |                                                                                                                                                                                      _开发中_                                                                                                                                                                                      |                                        |
|    翻译开放平台    | [![NuGet Version](https://img.shields.io/nuget/v/SKIT.FlurlHttpClient.Baidu.Translate.svg?label=NuGet)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Baidu.Translate) <br> [![NuGet Download](https://img.shields.io/nuget/dt/SKIT.FlurlHttpClient.Baidu.Translate.svg?sanitize=true&label=Downloads)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Baidu.Translate) | [开发文档](./docs/Translate/README.md) |
|       云推送       |           [![NuGet Version](https://img.shields.io/nuget/v/SKIT.FlurlHttpClient.Baidu.Push.svg?label=NuGet)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Baidu.Push) <br> [![NuGet Download](https://img.shields.io/nuget/dt/SKIT.FlurlHttpClient.Baidu.Push.svg?sanitize=true&label=Downloads)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Baidu.Push)           |   [开发文档](./docs/Push/README.md)    |

---

## 参与贡献

-   GitHub Repo：https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Baidu.git
-   Gitee Repo：https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Baidu.git

以上仓库地址同步更新，均可接受 Issue 或 Pull Request。

如何参与贡献请参阅 [CONTRIBUTING](./CONTRIBUTING.md)。

### 特别鸣谢：

-   感谢 [@code-jar](https://github.com/code-jar) 对此项目中智能小程序开放平台模块的突出贡献。

---

## 更新日志

详细更新说明请参阅 [CHANGELOG](./CHANGELOG.md)。
