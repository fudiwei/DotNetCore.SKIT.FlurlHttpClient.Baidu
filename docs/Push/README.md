# SKIT.FlurlHttpClient.Baidu.Push

基于 `Flurl.Http` 的[百度云推送](https://push.baidu.com/) HTTP API SDK。

---

## 功能

-   基于百度云推送 API 封装。
-   请求时自动生成签名，无需开发者手动干预。
-   提供了百度云推送 API 所需的 MD5 等算法工具类。

---

## 快速入门

### 安装：

提示：如果你使用 Visual Studio NuGet 管理器图形化界面，请在搜索结果中勾选“**包括预发行版**”。

```shell
# 通过 NuGet 安装
> Install-Package SKIT.FlurlHttpClient.Baidu.Push

# 通过 dotnet-tools 安装
> dotnet add package SKIT.FlurlHttpClient.Baidu.Push
```

### 初始化：

```csharp
using SKIT.FlurlHttpClient.Baidu.Push;

var options = new BaiduPushClientOptions()
{
    ApiKey = "百度云推送 API KEY",
    SecretKey = "百度云推送 Secret Key"
};
var client = BaiduPushClientBuilder.Create(options).Build();
```

### 请求 & 响应：

```csharp
using SKIT.FlurlHttpClient.Baidu.Push;
using SKIT.FlurlHttpClient.Baidu.Push.Models;

/* 以推送消息到单台设备接口为例 */
var request = new PushSingleDeviceRequest()
{
    ChannelId = "设备 ID",
    MessageType = 0,
    Message = new PushSingleDeviceRequest.Types.Message()
    {
        { "title", "通知标题" },
        { "description", "通知文本内容" },
        { "open_type": 1 },
        { "url", "https://push.baidu.com/" }
    },
    ExpiresIn = 86400
};
var response = await client.ExecutePushSingleDeviceAsync(request);
if (response.IsSuccessful())
{
    Console.WriteLine("消息 ID：" + response.Data.MessageId);
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

-   [如何与 `IHttpClientFactory` 集成？](./Advanced_IHttpClientFactory.md)

-   [如何指定 JSON 序列化器？](./Advanced_JsonSerializer.md)

-   [如何使用拦截器？](./Advanced_Interceptor.md)
