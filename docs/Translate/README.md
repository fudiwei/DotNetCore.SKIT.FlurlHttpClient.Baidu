# SKIT.FlurlHttpClient.Baidu.Translate

基于 `Flurl.Http` 的[百度翻译开放平台](https://api.fanyi.baidu.com/) HTTP API SDK。

---

## 功能

-   基于百度翻译开放平台 API 封装。
-   请求时自动生成签名，无需开发者手动干预。
-   提供了百度翻译开放平台 API 所需的 MD5、HMAC-SHA256 等算法工具类。

---

## 快速入门

### 安装：

提示：如果你使用 Visual Studio NuGet 管理器图形化界面，请在搜索结果中勾选“**包括预发行版**”。

```shell
# 通过 NuGet 安装
> Install-Package SKIT.FlurlHttpClient.Baidu.Translate

# 通过 dotnet-tools 安装
> dotnet add package SKIT.FlurlHttpClient.Baidu.Translate
```

### 初始化：

```csharp
using SKIT.FlurlHttpClient.Baidu.Translate;

var options = new BaiduTranslateClientOptions()
{
    AppId = "百度翻译 AppId",
    AppSecret = "百度翻译 AppSecret"
};
var client = BaiduTranslateClientBuilder.Create(options).Build();
```

### 请求 & 响应：

```csharp
using SKIT.FlurlHttpClient.Baidu.Translate;
using SKIT.FlurlHttpClient.Baidu.Translate.Models;

/* 以通用文本翻译接口为例 */
var request = new TranslateVipTranslateRequest()
{
    QueryString = "Hello, World!",
    From = "en",
    To = "zh"
};
var response = await client.ExecuteTranslateVipTranslateAsync(request);
if (response.IsSuccessful())
{
    Console.WriteLine("翻译结果：" + response.ResultList);
}
else
{
    Console.WriteLine("错误代码：" + response.ErrorCode);
    Console.WriteLine("错误描述：" + response.ErrorMessage);
}
```

---

## 基础用法

-   ⭐ [如何快速找到需要调用的 API 模型类名 / 方法名？](./Basic_ModelDefinition.md)

---

## 高级技巧

-   [配置 JSON 序列化器](./Advanced_JsonSerializer.md)

-   [配置 HttpClient](./Advanced_HttpClient.md)

-   [使用拦截器](./Advanced_Interceptor.md)

-   [避免内存泄漏](./Advanced_Dispose.md)

-   [与 `IHttpClientFactory` 集成](./Advanced_HttpClientFactory.md)
