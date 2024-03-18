namespace QI.Wx.Sdk.MiniProgram.Dtos;

/// <summary>
/// 获取小程序 URL Link 返回数据
/// </summary>
public class GenerateUrlLinkResult : ApiResultBase
{
    /// <summary>
    /// 获取或设置生成的小程序 URL Link。
    /// </summary>
    [JsonProperty("url_link")]
    public string UrlLink { get; set; } = string.Empty;
}
