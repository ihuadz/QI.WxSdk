using WebApiClientCore;
using QI.Wx.Sdk.MiniProgram.Apis.AuthUser.Dtos;

namespace QI.Wx.Sdk.MiniProgram.Apis;

/// <summary>
/// 小程序"登录/用户信息"相关接口
/// </summary>
public interface IWxMpAuthUserApi : IWxApiBase
{
    /// <summary>
    /// 通过code换取openId和授权信息
    /// </summary>
    /// <remarks>
    /// 获得openId 和 sessionKey
    /// 通过 wx.login 接口获得临时登录凭证 code 后传到开发者服务器调用此接口完成登录流程
    /// https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/user-login/code2Session.html
    /// https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/login.html
    /// </remarks>
    /// <param name="appid">小程序 appId</param>
    /// <param name="secret">小程序 appSecret</param>
    /// <param name="js_code">登录时获取的 code，可通过wx.login获取</param>
    /// <param name="grant_type">授权类型，此处只需填写 authorization_code</param>
    /// <returns></returns>
    [HttpGet("https://api.weixin.qq.com/sns/jscode2session")]
    ITask<Code2SessionResult> GetCode2SessionAsync([Required] string appid, [Required] string secret, [Required] string js_code, string grant_type = "authorization_code");


    /// <summary>
    /// 通过code换取用户手机号
    /// </summary>
    /// <remarks>
    /// 该接口用于将 code 换取用户手机号。 说明，每个 code 只能使用一次，code的有效期为5min
    /// https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/user-info/phone-number/getPhoneNumber.html
    /// </remarks>
    /// <param name="code">手机号获取凭证</param>
    /// <returns></returns>
    [AccessTokenApiFilter]
    [HttpPost("https://api.weixin.qq.com/wxa/business/getuserphonenumber")]
    ITask<GetUserPhonenumberResult> GetUserPhonenumberAsync([JsonNetContent(CharSet = "utf-8")] GetUserPhonenumberInput code);

}
