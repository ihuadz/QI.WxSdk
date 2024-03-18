namespace QI.Wx.Sdk.MiniProgram.Dtos;

/// <summary>
/// 公众号模板消息相关的信息
/// 下发小程序和公众号统一的服务消息时 mp_template_msg 部分定义的内容
/// </summary>
public class UniformMessageMpTemplateMsg
{
    /// <summary>
    /// 公众号appid，要求与小程序有绑定且同主体
    /// </summary>
    [JsonProperty("appid")]
    public string AppId { get; set; } = string.Empty;

    /// <summary>
    /// 公众号模板id
    /// </summary>
    [JsonProperty("template_id")]
    public string TemplateId { get; set; } = string.Empty;

    /// <summary>
    /// 公众号模板消息所要跳转的url
    /// </summary>
    [JsonProperty("url")]
    public string? Url { get; set; }

    /// <summary>
    /// 公众号模板消息所要跳转的小程序，小程序的必须与公众号具有绑定关系
    /// </summary>
    [JsonProperty("miniprogram")]
    public TemplateMessageMiniProgram MiniProgram { get; set; }

    /// <summary>
    /// 公众号模板消息内容
    /// 格式形如 { "key1": { "value": any }, "key2": { "value": any } }的object
    /// </summary>
    [JsonProperty("data")]
    public IDictionary<string, TemplateMessageDataItem> Data { get; set; } = new Dictionary<string, TemplateMessageDataItem>();
}
