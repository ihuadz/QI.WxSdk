using WebApiClientCore;
using QI.Wx.Sdk.MiniProgram.Dtos;

namespace QI.Wx.Sdk.MiniProgram.Apis;

/// <summary>
/// 小程序 URL Link, URL Scheme 接口
/// </summary>
public interface IWxMpUrllinkApi : IWxApiWithAccessTokenFilter
{
    /// <summary>
    /// 获取小程序 URL Link
    /// </summary>
    /// <remarks>
    /// 适用于短信、邮件、网页、微信内等拉起小程序的业务场景。目前仅针对国内非个人主体的小程序开放
    /// 每天生成 URL Scheme 和 URL Link 总数量上限为50万
    /// 只能生成已发布的小程序的 URL Link。
    /// 在微信内或者安卓手机打开 URL Link 时，默认会先跳转官方 H5 中间页，如果需要定制 H5 内容，可以使用云开发静态网站。
    /// https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/url-link/urllink.generate.html
    /// https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/url-link.html
    /// </remarks>
    /// <param name="input">请求数据</param>
    /// <returns></returns>
    [HttpPost("https://api.weixin.qq.com/wxa/generate_urllink")]
    ITask<GenerateUrlLinkResult> GenerateUrllinkAsync([JsonNetContent] GenerateUrlLinkInput input);
}
