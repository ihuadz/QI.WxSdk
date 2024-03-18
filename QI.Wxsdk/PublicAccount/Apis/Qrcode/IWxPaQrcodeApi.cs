using System.Threading.Tasks;
using WebApiClientCore.Attributes;
using QI.Wx.Sdk.Core;
using QI.Wx.Sdk.PublicAccount.Apis.Qrcode;

namespace QI.Wx.Sdk.PublicAccount.Apis
{
    /// <summary>
    /// 公众号生成带参数的二维码
    /// </summary>
    /// <remarks>
    /// https://developers.weixin.qq.com/doc/offiaccount/Account_Management/Generating_a_Parametric_QR_Code.html
    /// </remarks>
    [HttpHost("https://api.weixin.qq.com/cgi-bin/qrcode/")]
    public interface IWxPaQrcodeApi : IWxApiWithAccessTokenFilter
    {
        /// <summary>
        /// 创建二维码
        /// </summary>
        /// <remarks>
        /// 每次创建二维码 ticket 需要提供一个开发者自行设定的参数（scene_id），分别介绍临时二维码和永久二维码的创建二维码 ticket 过程。
        /// </remarks>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("create")]
        Task<QrcodeApiResult> CreateAsync([JsonNetContent(CharSet = "utf-8")] QrcodeInput input);
    }
}