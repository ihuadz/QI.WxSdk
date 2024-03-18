using WebApiClientCore;
using QI.Wx.Sdk.MiniProgram.Dtos;

namespace QI.Wx.Sdk.MiniProgram.Apis;

/// <summary>
/// 微信小程序消息相关接口
/// https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/subscribe-message.html
/// </summary>
public interface IWxMpMessageApi : IWxApiWithAccessTokenFilter
{
    /// <summary>
    /// 发送订阅消息
    /// </summary>
    /// <remarks>
    /// 需要在小程序后台创建模板消息,并提交审核通过后才能使用
    /// 小程序前端,需要调用方法让用户确认订阅消息
    /// https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/subscribe-message.html
    /// https://developers.weixin.qq.com/miniprogram/dev/api/open-api/subscribe-message/wx.requestSubscribeMessage.html
    /// https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/mp-message-management/subscribe-message/sendMessage.html
    /// </remarks>
    /// <param name="input">请求数据</param>
    /// <returns></returns>
    [HttpPost("https://api.weixin.qq.com/cgi-bin/message/subscribe/send")]
    ITask<ApiResultBase> SendSubscribeMessageAsync([JsonNetContent] SubscribeMessageSendInput input);

    /// <summary>
    /// 下发小程序和公众号统一的服务消息
    /// </summary>
    /// <remarks>
    /// 公众号与小程序有绑定且同主体, 就可以通过小程序并使用小程序的openid发送"公众号模板消息"
    /// <br/>用户需要关注公众号，模板消息才能发送成功
    /// <br/>公众号模板消息的日调用上限为10万次，单个模板没有特殊限制
    /// <br/>公众号每个账号可以同时使用25个模板
    /// https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/uniform-message/uniformMessage.send.html
    /// </remarks>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost("https://api.weixin.qq.com/cgi-bin/message/wxopen/template/uniform_send")]
    ITask<ApiResultBase> SendUniformMessageAsync([JsonNetContent] UniformMessageSendInput input);

}
