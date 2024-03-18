namespace QI.Wx.Sdk.MiniProgram.Dtos;

/// <summary>
/// <para>表示 [POST] /cgi-bin/wxaapp/createwxaqrcode 接口的请求。</para>
/// </summary>
public class CreateQRCodeInput
{
    /// <summary>
    /// 扫码进入的小程序页面路径，最大长度 128 字节，不能为空
    /// </summary>
    [JsonProperty("path")]
    public string Path { get; set; } = string.Empty;

    /// <summary>
    /// 二维码的宽度，单位 px。最小 280px，最大 1280px
    /// </summary>
    [JsonProperty("width")]
    public int? Width { get; set; } = 430;
}
