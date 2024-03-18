namespace QI.Wx.Sdk.MiniProgram.Dtos;

/// <summary>
/// GetWxaCode返回
/// </summary>
public class GetWxaCodeResult : ApiResultBase
{
    /// <summary>
    /// 获取原始的 HTTP 响应数据
    /// </summary>
    [JsonIgnore]
    public byte[] RawBytes { get; set; }

    private string base64Image = string.Empty;

    /// <summary>
    /// base64 image数据
    /// </summary>
    /// <remarks>需要先调用ToBase64Image转化一下</remarks>
    public string Base64Image => base64Image;

    /// <summary>
    /// RawByte转化成 base64 image, 使用Base64Image属性返回
    /// </summary>
    /// <returns></returns>
    public void ToBase64Image()
    {
        base64Image = (RawBytes==null && RawBytes.Length==0) ? "" : "data:image/png;base64," + RawBytes.ToBase64();
    }
}
