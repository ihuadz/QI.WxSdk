using QI.Wx.Sdk.MiniProgram.Apis;
using QI.Wx.Sdk.MiniProgram.Apis.AuthUser.Dtos;

namespace QI.Wx.Sdk.MiniProgram
{
    /// <summary>
    /// 微信小程序接口聚合服务, 生命周期为Scoped
    /// </summary>
    public class WxMpApiService : WxApiServiceBase
    {
        /// <summary>
        /// 微信小程序接口集合服务
        /// </summary>
        /// <param name="tokenManager"></param>
        public WxMpApiService(ITokenManager tokenManager):base(tokenManager){}

        /// <summary>
        /// 小程序"登录/用户信息"相关接口
        /// </summary>
        public IWxMpAuthUserApi IAuthUserApi => GetService<IWxMpAuthUserApi>();

        /// <summary>
        /// 小程序 URL Link, URL Scheme 接口
        /// </summary>
        public IWxMpUrllinkApi IUrllinkApi => GetService<IWxMpUrllinkApi>();

        /// <summary>
        /// 小程序二维码相关接口
        /// </summary>
        public IWxMpQRCodeApi IQRCodeApi => GetService<IWxMpQRCodeApi>();

        /// <summary>
        /// 小程序消息接口
        /// </summary>
        public IWxMpMessageApi IMessageApi => GetService<IWxMpMessageApi>();

        /// <summary>
        /// 通过code换取openId和授权信息,使用当前Wx会话
        /// 如果accesstoken无效，则会再试一次
        /// </summary>
        /// <remarks>
        /// 获得openId 和 sessionKey
        /// 通过 wx.login 接口获得临时登录凭证 code 后传到开发者服务器调用此接口完成登录流程
        /// https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/user-login/code2Session.html
        /// https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/login.html
        /// </remarks>
        /// <param name="code">登录时获取的 code，可通过wx.login获取</param>
        /// <returns></returns>
        [HttpGet("https://api.weixin.qq.com/sns/jscode2session")]
        public virtual async Task<Code2SessionResult> GetCode2SessionAsync([Required] string code)
        {
            var wxapp = TokenManager.GetCurApp();
            var ret = await IAuthUserApi.GetCode2SessionAsync(wxapp.AppId, wxapp.AppSecret, code);
            //如果accesstoken无效，则再试一次
            if (ret.IsAccessTokenInvalid)
            {
                //重新获取token
                await TokenManager.GetNewAccessTokenAsync();
                //再重试一次
                ret = await IAuthUserApi.GetCode2SessionAsync(wxapp.AppId, wxapp.AppSecret, code);
            }
            return ret;
        }
    }
}
