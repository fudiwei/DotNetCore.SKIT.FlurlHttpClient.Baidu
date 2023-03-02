## 如何快速找到需要调用的 API 模型类名 / 方法名？

---

本库提供的请求模型、响应模型和接口方法，三者均保持同名。

例如，推送模板消息的请求是 `RestTemplateSendRequest`，响应是 `RestTemplateSendResponse`，接口是 `ExecuteRestTemplateSendAsync()`。知道其中一个，其余两个就可以快速地推断出了。

再有，每个对象的命名与官方文档的接口地址大体保持一致。例如刚刚提到的推送模板消息，它的接口地址是 `[POST] /rest/2.0/smartapp/template/send`，将其中的反斜杠去掉、忽略固定段“/2.0/smartapp/”、并以大驼峰命名法的方式调整它，就可以得到前文提到的几个对象了。如果路由中带有版本信息，那么版本号一般都在结尾处，例如接口 `[POST] /rest/2.0/smartapp/riskDetection/v2/syncCheckText` 对应的是 `RestRiskDetectionSyncCheckTextV2`。

完整的模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.Baidu.SmartApp/SDK/OpenApi/Models_、_src/SKIT.FlurlHttpClient.Baidu.SmartApp/SDK/ThirdParty/Models_ 目录。

---

### 百度智能小程序开放平台 API 支持情况：

#### 1. 服务端 OpenAPI

<details>

<summary>[展开查看]</summary>

|     |   百度 API   | 备注 |
| :-: | :----------: | :--: |
|  √  | 接口调用凭证 |      |
|  √  |     登录     |      |
|  √  |     卡券     |      |
|  √  | 流量分发资源 |      |
|  √  |   消息推送   |      |
|  √  |   模板消息   |      |
|  √  |   订阅消息   |      |
|  √  |   客服消息   |      |
|  √  |   订单同步   |      |
|  √  |   风控服务   |      |
|  √  | 小程序二维码 |      |
|  √  | 互动数据获取 |      |
|  √  | 内容安全检测 |      |

</details>

#### 2. 第三方平台 OpenAPI

<details>

<summary>[展开查看]</summary>

|     |    百度 API    | 备注 |
| :-: | :------------: | :--: |
|  √  |    授权流程    |      |
|  √  |   真实性认证   |      |
|  √  |    模板管理    |      |
|  √  |  小程序包管理  |      |
|  √  |  基本信息设置  |      |
|  √  |    违规下线    |      |
|  √  | 模板/订阅消息  |      |
|  √  |    图片上传    |      |
|  √  |   小程序登录   |      |
|  √  |    性能优化    |      |
|  √  |   获取手机号   |      |
|  √  |    支付服务    |      |
|  √  |    订单同步    |      |
|  √  |  数据统计分析  |      |
|  √  |    客服消息    |      |
|  √  | 设置第三方域名 |      |
|  √  |    自然搜索    |      |
|  √  |     信息流     |      |
|  √  |    消息推送    |      |
|  √  |   小程序等级   |      |

</details>
