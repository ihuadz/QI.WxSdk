# 微信接口SDK

名称: QI.Wx.Sdk
Sdk 使用 WebApiClient 把微信接口进行了封装，映射成了本地接口
调用本地接口就可以 访问微信接口
微信接口返回的数据 也封装成了相应的对象

参考项目：

- Magicodes.Wx.Sdk
  https://gitee.com/xl_wenqiang/Magicodes.Wx.Sdk

- SKIT.FlurlHttpClient.Wechat
  https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient

示例项目 QI-wxapi

# 使用说明

### 1、注册服务

WxSDK会缓存获得的微信access_token，这需要先注册 IDistributedCache

具体是由 Redis 或 Memory 来缓存，要看 注册的 IDistributedCache 实现

示例代码：

```csharp
    //注册缓存相关
    services.AddCacheSetup(App.Configuration);

    //注册微信Sdk集成
    services.AddWxSdkApiAndServices();
    //注册微信Token管理器,负责AccessToken的获取\缓存
    //也可以注册自己定义的Token管理器，只要继承接口ITokenManager
    services.AddWxSdkTokenManager();

    //或 注册全部
    //services.AddWxSdkAll();

```

### 2、WxConfig 与 WxAppSetting

WxConfig会自动从配置文件中加载内容定义的 appId和 appSecret。

比如: 

```yaml
# 微信应用(公众号/小程序)
WeixinSetting:
# 应用配置
  App:
    - AppId: xxxxxxxxxxxxxxxx
      AppSecret: xxxxxxxxxxxxxxx
      Name: 测试公众号
    - AppId: xxxxxxxxxxxxxxxx
      AppSecret: xxxxxxxxxxxxxxxxx
      Name: 小程序
```

WxConfig 在 调用 services.AddWxSdk() 已注册，是单实例模式。

每个应用配置是一个 WxAppSetting 对象，保存了 appId和 appSecret。

如果只配置了1个应用, 会自动把这个应用设置为 WxConfig.DefaultAppSetting

### 3、ITokenManager Token管理器 和 微信 access_token管理

微信的接口访问时，基本上都需要一个 access_token 参数

ITokenManager 自动从微信服务获取 access_token 并把它缓存起来(按token的过期时间缓存)。

所有 WxSdk 封装的微信服务接口，需要 access_token 时，都会自动从 ITokenManager 获取。

如果因为业务的需要，token获取逻辑有所不同，可以继承 ITokenManager，自行实现一个 Token管理器 并注入。

> 使用 ITokenManager来获得 access_token

获得 ITokenManager 的实例后，调用 SetCurApp(xxx) 来设置当前会话使用的 app。
如果只配置了一个应用, 会自动设置成当前应用
ITokenManager 的生命周期是 Scope , 可以实现 多个应用共存。

```csharp
//方式1,根据Appid从WxContext中查找
tokenManager.SetCurApp("")

//方式2, 创建一个WxAppSetting对象来设置
var wxapp = new WxAppSetting(appId,appSecret);
tokenManager.SetCurApp(wxapp);

//获取token, 优先从缓存中查询，如果没有缓存token时才从腾讯获取
var token = await tokenManager.GetAccessTokenAsync();

```

### 4、使用 WxMpApiService 来访问小程序接口服务

示例代码见  QI.Wxapi.Application 项目的 WxMpAppService.cs
