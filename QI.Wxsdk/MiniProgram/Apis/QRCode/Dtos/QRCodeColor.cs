using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QI.Wx.Sdk.MiniProgram.Apis.QRCode.Dtos;

/// <summary>
/// 颜色
/// </summary>
public class QRCodeColor
{
    /// <summary>
    /// 获取或设置红色色值。
    /// </summary>
    [JsonProperty("r")]
    public byte Red { get; set; } = 0;

    /// <summary>
    /// 获取或设置绿色色值。
    /// </summary>
    [JsonProperty("g")]
    public byte Green { get; set; } = 0;

    /// <summary>
    /// 获取或设置蓝色色值。
    /// </summary>
    [JsonProperty("b")]
    public byte Blue { get; set; } = 0;
}
