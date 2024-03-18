namespace QI.Wx.Sdk.MiniProgram.Dtos;

/// <summary>
/// 发送订阅消息的请求数据
/// </summary>
/// https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/mp-message-management/subscribe-message/sendMessage.html
/// <remarks>
/// </remarks>
public class SubscribeMessageSendInput 
{
    /// <summary>
    /// 所需下发的订阅模板id
    /// </summary>
    [JsonProperty("template_id")]
    public string TemplateId { get; set; } = string.Empty;

    /// <summary>
    /// 点击模板卡片后的跳转页面
    /// <br/>仅限本小程序内的页面。支持带参数,（示例index?foo=bar）。该字段不填则模板无跳转
    /// </summary>
    [JsonProperty("page")]
    public string Page { get; set; } = string.Empty;

    /// <summary>
    /// 接收者（用户）的 openid
    /// </summary>
    [JsonProperty("touser")]
    public string ToUserOpenId { get; set; } = string.Empty;

    /// <summary>
    /// 跳转小程序类型
    /// <br/>developer为开发版；trial为体验版；formal为正式版；默认为正式版
    /// </summary>
    [JsonProperty("miniprogram_state")]
    public string MiniProgramState { get; set; } = ConstWx.MP_Env_Ver_Release2;

    /// <summary>
    /// 进入小程序查看”的语言类型
    /// 支持zh_CN(简体中文)、en_US(英文)、zh_HK(繁体中文)、zh_TW(繁体中文)，默认为zh_CN
    /// </summary>
    [JsonProperty("lang")]
    public string Language { get; set; } = ConstWx.MP_Language_zh_CN;

    /// <summary>
    /// 模板内容
    /// 格式形如 { "key1": { "value": any }, "key2": { "value": any } }的object
    /// </summary>
    [JsonProperty("data")]
    public IDictionary<string, TemplateMessageDataItem> Data { get; set; } = new Dictionary<string, TemplateMessageDataItem>();
}
