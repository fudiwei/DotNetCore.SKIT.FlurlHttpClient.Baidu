## 如何验证回调通知事件签名？

---

> 请先自行阅读：
>
> [《百度智能小程序文档中心 - 服务端 - 消息推送：验证消息的确来自百度服务器》](https://smartprogram.baidu.com/docs/develop/serverapi/developer_event_push/)

同样的，你既可以利用本库提供的 `SHA1Utility` 工具类自行进行签名验证，也可以通过扩展方法实现：

```csharp
/* 在初始化客户端时需指定服务器推送的相关参数 */
var options = new BaiduSmartAppOpenApiClientOptions()
{
    // 其他配置项略
    PushToken = "Token",
    PushEncodingAESKey = "EncodingAESKey"
};
var client = new BaiduSmartAppOpenApiClient(options);

/* 验证百度小程序服务器 */
bool ret = client.VerifyEventSignatureForEcho(
    webhookTimestamp: "百度小程序回调通知中的 timestamp 字段",
    webhookNonce: "百度小程序回调通知中的 nonce 字段",
    webhookSignature: "百度小程序回调通知中的 signature 字段"
);

/* 验证安全模式下 XML 消息的签名 */
bool ret = client.VerifyEventSignatureFromXml(
    webhookXml: "百度小程序发来的通知内容，形如：<xml><Encrypt>...</Encrypt></xml>"
);

/* 验证安全模式下 JSON 消息的签名 */
bool ret = client.VerifyEventSignatureFromJson(
    webhookJson: "百度小程序发来的通知内容，形如：{\"Encrypt\":\"...\"}"
);
```
