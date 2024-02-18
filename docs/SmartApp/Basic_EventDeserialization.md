## 如何解析回调通知事件？

---

对于百度小程序推送过来的回调通知事件，本库封装了直接解析成事件模型的扩展方法，下面给出一个示例：

```csharp
/* 如果是 JSON 格式的通知内容，以 text 事件为例 */
string webhookJson = "{ ... }";
var webhookModel = client.DeserializeEventFromJson<Events.TextMessageEvent>(webhookJson);

/* 如果是 XML 格式的通知内容，以 text 事件为例 */
string webhookXml = "<xml> ... </xml>";
var webhookModel = client.DeserializeEventFromXml<Events.TextMessageEvent>(webhookXml);
```

完整的回调通知模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.Baidu.SmartApp/ExtendedSDK/OpenApi/Events_、_src/SKIT.FlurlHttpClient.Baidu.SmartApp/ExtendedSDK/ThirdParty/Events_ 目录。

---

### 事件类型：

由于百度小程序会将全部事件推送到同一个回调通知地址上，开发者需要根据事件类型才能决定如何反序列化。

这里给出两种解决方案。

一种是利用 `System.Xml.Linq`：

```csharp
XDocument xDoc = XDocument.Parse(webhookXml);
string msgType = xDoc.Root?.Element("MsgType")?.Value?.ToUpper();
```

另一种是利用本库的扩展方法：

```csharp
BaiduSmartAppOpenApiEvent eventModel = client.DeserializeEventFromXml(webhookXml);
string msgType = eventModel.MessageType?.ToUpper();

switch (msgType)
{
    case "TEXT":
        {
            var webhookModel = client.DeserializeEventFromXml<Events.TextMessageEvent>(webhookXml);
        }
        break;
    // 省略其他情况
}
```

---

### 安全模式：

在安全模式下，百度小程序使用了一种特殊的 AES 算法对回调通知事件加密。

上述提供的扩展方法，会自动判定是否处于安全模式下，无需开发者手动干预。

为此，你需要在构造得到 `BaiduSmartAppOpenApiClientOptions` 或 `BaiduSmartAppThirdPartyClientOptions` 对象时指定推送参数：

```csharp
var options = new BaiduSmartAppOpenApiClientOptions()
{
    // 其他配置项略
    PushToken = "Token",
    PushEncodingAESKey = "EncodingAESKey"
};
var client = BaiduSmartAppOpenApiClientBuilder.Create(options).Build();
```
