namespace QI.Wx.Sdk.MiniProgram.Dtos;

/// <summary>
/// 统一消息里，公众号模板消息里的 小程序信息
/// </summary>
public class TemplateMessageMiniProgram
{
    /// <summary>
    /// 小程序 AppId。
    /// </summary>
    [JsonProperty("appid")]
    public string AppId { get; set; } = string.Empty;

    /// <summary>
    /// 小程序页面路径,可带参数，比如index?foo=bar
    /// 为空表示首页    ///
    /// </summary>
    [JsonProperty("pagepath")]
    public string PagePath { get; set; } = string.Empty;
}
