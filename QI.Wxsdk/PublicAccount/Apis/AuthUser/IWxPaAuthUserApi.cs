using System.ComponentModel.DataAnnotations;
using WebApiClientCore.Attributes;
using QI.Wx.Sdk.Core;
using QI.Wx.Sdk.PublicAccount.Apis.AuthUser.Dtos;

namespace QI.Wx.Sdk.PublicAccount.Apis
{
    /// <summary>
    /// 公众号"认证/用户信息"相关接口
    /// </summary>
    /// <remarks>
    /// https://developers.weixin.qq.com/doc/offiaccount/OA_Web_Apps/Wechat_webpage_authorization.html
    /// </remarks>
    public interface IWxPaAuthUserApi : IWxApiBase
    {
        /// <summary>
        /// 通过code换取网页授权
        /// </summary>
        /// <remarks>
        /// 获得OAuth access_token 和 openId
        /// </remarks>
        /// <param name="appid">公众号的唯一标识</param>
        /// <param name="secret"></param>
        /// <param name="code"></param>
        /// <param name="grant_type">默认为authorization_code</param>
        /// <returns></returns>
        [HttpGet("https://api.weixin.qq.com/sns/oauth2/access_token")]
        Task<OAuthAccessTokenApiResult> GetOAuthAccessTokenAsync([Required] string appid, [Required] string secret, [Required] string code, string grant_type = "authorization_code");

        /// <summary>
        /// 刷新OAuth access_token
        /// </summary>
        /// <remarks>
        /// 由于OAuth access_token拥有较短的有效期，当access_token超时后，可以使用refresh_token进行刷新。
        /// refresh_token有效期为30天，当refresh_token失效之后，需要用户重新授权。
        /// </remarks>
        /// <param name="appId"></param>
        /// <param name="refresh_token"></param>
        /// <param name="grant_type"></param>
        /// <returns></returns>
        [HttpGet("https://api.weixin.qq.com/sns/oauth2/refresh_token")]
        Task<OAuthRefreshTokenApiResult> OAuthRefreshTokenAsync([Required] string appId, [Required] string refresh_token, string grant_type = "refresh_token");

        /// <summary>
        /// 拉取用户信息
        /// </summary>
        /// <remarks>
        /// (需scope为 snsapi_userinfo)
        /// token和openid在 "通过code换取网页授权" 接口调用中获得。
        /// </remarks>
        /// <param name="oAuthAccessToken">网页授权接口调用凭证</param>
        /// <param name="openid"></param>
        /// <param name="lang">返回国家地区语言版本，zh_CN 简体，zh_TW 繁体，en 英语</param>
        /// <returns></returns>
        [HttpGet("https://api.weixin.qq.com/sns/userinfo?access_token={oAuthAccessToken}")]
        Task<GetUserInfoApiResult> GetUserInfoAsync(string oAuthAccessToken, string openid, string lang = "zh_CN");

        /// <summary>
        /// 检验授权凭证OAuth access_token是否有效
        /// </summary>
        /// <param name="oAuthAccessToken">网页授权接口调用凭证</param>
        /// <param name="openid"></param>
        /// <returns></returns>
        [HttpGet("https://api.weixin.qq.com/sns/auth?access_token={oAuthAccessToken}")]
        Task<ApiResultBase> AuthAsync(string oAuthAccessToken, string openid);
    }
}
