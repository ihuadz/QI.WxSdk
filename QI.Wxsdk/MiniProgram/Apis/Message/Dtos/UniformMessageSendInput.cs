namespace QI.Wx.Sdk.MiniProgram.Dtos;

/// <summary>
/// 下发小程序和公众号统一的服务消息 请求数据
/// </summary>
public class UniformMessageSendInput
{
    /// <summary>
    /// 接收者（用户）的 openid
    /// 可以是小程序的openid，也可以是 公众号消息模板 对应的公众号的openid
    /// </summary>
    [JsonProperty("touser")]
    public string ToUserOpenId { get; set; } = string.Empty;

    /// <summary>
    /// 公众号模板消息相关的信息
    /// </summary>
    [JsonProperty("mp_template_msg")]
    public UniformMessageMpTemplateMsg MpTemplateMsg { get; set; }

}
