﻿# SKIT.FlurlHttpClient.Baidu.SmartApp

基于 `Flurl.Http` 的[百度智能小程序开放平台](https://smartprogram.baidu.com/) HTTP API SDK。

---

## 功能

-   基于百度智能小程序开放平台 API 封装。
-   支持全部服务端 OpenAPI、第三方平台 OpenAPI。
-   提供了百度智能小程序开放平台 API 所需的 SHA-1 等算法工具类。
-   提供了解析消息推送事件等扩展方法。

---

## 快速入门

### 安装：

提示：如果你使用 Visual Studio NuGet 管理器图形化界面，请在搜索结果中勾选“**包括预发行版**”。

```shell
# 通过 NuGet 安装
> Install-Package SKIT.FlurlHttpClient.Baidu.SmartApp

# 通过 dotnet-tools 安装
> dotnet add package SKIT.FlurlHttpClient.Baidu.SmartApp
```

### 初始化：

```csharp
/* 以服务端 OpenAPI 为例 */
using SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi;

var options = new BaiduSmartAppOpenApiClientOptions()
{
    AppId = "百度小程序 AppId",
    AppKey = "百度小程序 AppKey",
    AppSecret = "百度小程序 AppSecret",
    PaymentServiceAppKey = "百度收银台相关服务 AppKey，不用则不填"
};
var client = BaiduSmartAppOpenApiClientBuilder.Create(options).Build();



/* 以第三方平台 OpenAPI 为例 */
using SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty;

var options = new BaiduSmartAppThirdPartyClientOptions()
{
    AppId = "百度小程序 AppId",
    AppKey = "百度小程序 AppKey",
    AppSecret = "百度小程序 AppSecret",
    PaymentServiceAppKey = "百度收银台相关服务 AppKey，不用则不填"
};
var client = BaiduSmartAppThirdPartyClientBuilder.Create(options).Build();
```

### 请求 & 响应：

```csharp
using SKIT.FlurlHttpClient.Baidu.SmartApp;
using SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models;

/* 以服务端 OpenAPI 获取小程序二维码短链接口为例 */
var request = new RestQrcodeGetV2Request()
{
    PagePath = "/pages/index",
    Width = 480
};
var response = await client.ExecuteRestQrcodeGetV2Async(request);
if (response.IsSuccessful())
{
    Console.WriteLine("二维码链接：" + response.Data.QrcodeUrl);
}
else
{
    Console.WriteLine("错误代码：" + response.ErrorNumber);
    Console.WriteLine("错误描述：" + response.ErrorMessage);
}
```

---

## 基础用法

-   ⭐ [如何快速找到需要调用的 API 模型类名 / 方法名？](./Basic_ModelDefinition.md)

-   [如何解析回调通知事件？](./Basic_EventDeserialization.md)

-   [如何验证回调通知事件签名？](./Basic_EventSignatureVerification.md)

---

## 高级技巧

-   [配置 JSON 序列化器](./Advanced_JsonSerializer.md)

-   [配置 HttpClient](./Advanced_HttpClient.md)

-   [使用拦截器](./Advanced_Interceptor.md)

-   [避免内存泄漏](./Advanced_Dispose.md)

-   [与 `IHttpClientFactory` 集成](./Advanced_HttpClientFactory.md)
