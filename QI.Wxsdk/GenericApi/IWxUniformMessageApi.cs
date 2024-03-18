using QI.Wx.Sdk.GenericApi.Dtos;
using QI.Wx.Sdk.MiniProgram.Apis.AuthUser.Dtos;

namespace QI.Wx.Sdk.GenericApi
{

    /// <summary>
    /// 统一服务消息
    /// </summary>
    /// <remarks>
    /// 小程序和公众号统一的服务消息,消息发送到微信的 "服务通知" 里
    /// https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/uniform-message/uniformMessage.send.html
    /// </remarks>
    public interface IWxUniformMessageApi : IWxApiWithAccessTokenFilter
    {
        /// <summary>
        /// 下发小程序和公众号统一的服务消息
        /// </summary>
        /// <remarks>
        /// https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/uniform-message/uniformMessage.send.html
        /// </remarks>
        /// <param name="messageInput"></param>
        /// <returns></returns>
        [HttpPost("https://api.weixin.qq.com/cgi-bin/message/wxopen/template/uniform_send")]
        Task<ApiResultBase> SendAsync([JsonNetContent] UniformMessageInput messageInput);
    }
}
