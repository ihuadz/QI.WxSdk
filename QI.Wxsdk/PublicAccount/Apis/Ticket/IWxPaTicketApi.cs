using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WebApiClientCore.Attributes;
using QI.Wx.Sdk.Core;
using QI.Wx.Sdk.PublicAccount.Apis.Ticket.Dtos;

namespace QI.Wx.Sdk.PublicAccount.Apis
{
    /// <summary>
    /// 公众号Ticket接口,使用JSAPI时需要
    /// </summary>
    [HttpHost("https://api.weixin.qq.com/cgi-bin/ticket/")]
    public interface IWxPaTicketApi : IWxApiWithAccessTokenFilter
    {

        /// <summary>
        /// 获取ticket
        /// </summary>
        /// <param name="type">The type. [jsapi|wx_card]</param>
        /// <returns></returns>
        [HttpGet("getticket")] 
        Task<GetTicketApiResult> GetAsync([Required] string type = "jsapi");
    }
}
