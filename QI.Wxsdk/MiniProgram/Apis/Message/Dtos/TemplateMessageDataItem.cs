namespace QI.Wx.Sdk.MiniProgram.Dtos;

/// <summary>
/// 模板消息 data 数据项
/// </summary>
public class TemplateMessageDataItem
{
    /// <summary>
    /// 
    /// </summary>
    public TemplateMessageDataItem() { }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    public TemplateMessageDataItem(string value) { this.Value = value ?? string.Empty; }

    /// <summary>
    /// 获取或设置消息内容文本。
    /// </summary>
    [JsonProperty("value")]
    public string Value { get; set; } = string.Empty;
}
