namespace QI.Wx.Sdk;

/// <summary>
/// 微信应用(公众号/小程序)配置信息
/// </summary>
public class WxAppSetting
{
    /// <summary>
    /// 微信应用(公众号/小程序)配置信息
    /// </summary>
    public WxAppSetting()
    {

    }

    /// <summary>
    /// 微信应用(公众号/小程序)配置信息
    /// </summary>
    /// <param name="appId">appId</param>
    /// <param name="appSecret">appSecret</param>
    /// <param name="name">name</param>
    /// <param name="appType">0未知，1公众号，2小程序</param>
    public WxAppSetting(string appId,string appSecret,string name = "",int appType = 0)
    {
        this.Name = name;
        this.AppId = appId;
        this.AppSecret = appSecret;
        this.AppType = appType;
    }

    /// <summary>
    /// 应用名称
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// AppId
    /// </summary>
    public string AppId { get; set; }

    /// <summary>
    /// AppSecret
    /// </summary>
    public string AppSecret { get; set; }

    /// <summary>
    /// 0未知，1公众号，2小程序
    /// </summary>
    public int AppType { get; set; } = 0;
}
