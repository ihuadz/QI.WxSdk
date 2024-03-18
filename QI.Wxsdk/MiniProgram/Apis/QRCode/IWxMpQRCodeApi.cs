using WebApiClientCore;
using QI.Wx.Sdk.MiniProgram.Apis.QRCode;
using QI.Wx.Sdk.MiniProgram.Dtos;

namespace QI.Wx.Sdk.MiniProgram.Apis;

/// <summary>
/// 小程序 二维码 接口
/// </summary>
public interface IWxMpQRCodeApi : IWxApiWithAccessTokenFilter
{
    /// <summary>
    /// 获取小程序二维码,适用于需要的码数量较少的业务场景
    /// </summary>
    /// <remarks>
    /// 通过该接口生成的小程序码，永久有效，有数量限制
    /// 与 GetWxaCode 总共生成的码数量限制为100,000
    /// 接口只能生成已发布的小程序的二维码
    /// https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/qr-code/wxacode.createQRCode.html
    /// <param name="input">请求数据</param>
    /// <returns></returns>
    [QRCodeApiFilter]
    [HttpPost("https://api.weixin.qq.com/cgi-bin/wxaapp/createwxaqrcode")]
    ITask<GetWxaCodeResult> CreateQRCodeAsync([JsonNetContent] CreateQRCodeInput input);

    /// <summary>
    /// 获取小程序二维码,适用于需要的码数量较少的业务场景
    /// </summary>
    /// <remarks>
    /// 通过该接口生成的小程序码，永久有效，有数量限制
    /// 可以指定版本，正式版为 release，体验版为 trial，开发版为 develop
    /// 与 CreateQRCode 总共生成的码数量限制为 100,000
    /// https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/qr-code/wxacode.get.html
    /// </remarks>
    /// <returns>
    /// 如果调用成功，会直接返回图片二进制内容，如果请求失败，会返回 JSON 格式的数据
    /// </returns>
    [QRCodeApiFilter]
    [HttpPost("https://api.weixin.qq.com/wxa/getwxacode")]
    ITask<GetWxaCodeResult> GetWxaCodeAsync([JsonNetContent] GetWxaCodeInput input);

    /// <summary>
    /// 获取小程序码，适用于需要的码数量极多的业务场景
    /// </summary>
    /// <remarks>
    /// 通过该接口生成的小程序码，永久有效，数量暂无限制
    /// 可以指定版本，正式版为 release，体验版为 trial，开发版为 develop
    /// 调用分钟频率受限（5000次/分钟），如需大量小程序码，建议预生成
    /// https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/qr-code/wxacode.getUnlimited.html
    /// </remarks>
    /// <param name="input"></param>
    /// <returns></returns>
    [QRCodeApiFilter]
    [HttpPost("https://api.weixin.qq.com/wxa/getwxacodeunlimit")]
    ITask<GetWxaCodeResult> GetWxaCodeUnlimitedAsync([JsonNetContent] GetWxaCodeUnlimitedInput input);
}
