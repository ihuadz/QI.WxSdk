using QI.Wx.Sdk.Core;
using QI.Wx.Sdk.Helper;
using QI.Wx.Sdk.PublicAccount.Apis;
using QI.Wx.Sdk.PublicAccount.Services.Dtos;

namespace QI.Wx.Sdk.PublicAccount
{
    /// <summary>
    /// JsApi相关接口聚合服务
    /// </summary>
    public class WxPaApiService : WxApiServiceBase
    {
        readonly IWxPaTicketApi ticketApi;
        readonly ITokenManager tokenManager;

        /// <summary>
        /// 微信公众号接口聚合服务
        /// </summary>
        /// <param name="tokenManager"></param>
        public WxPaApiService(ITokenManager tokenManager) : base(tokenManager) { }

        /// <summary>
        /// 获取 Ticket 接口
        /// </summary>
        public IWxPaTicketApi ITicketApi => GetService<IWxPaTicketApi>();

        /// <summary>
        /// 用户认证相关接口
        /// </summary>
        public IWxPaAuthUserApi IAuthUserApi => GetService<IWxPaAuthUserApi>();

        /// <summary>
        /// 获取jsapi的ticket
        /// </summary>
        /// <returns></returns>
        private async Task<string> GetJsApiTicketAsync()
        {
            var cacheKey = $"{ConstWx.WX_CACHE_JsApiTicket}:{tokenManager.GetCurAppId()}";
            //先查询缓存
            var ticket = await tokenManager.GetCacheAsync(cacheKey);

            if (!string.IsNullOrEmpty(ticket)) return ticket;

            //从微信获取ticket
            var result = await ticketApi.GetAsync();
            if (result.IsSuccess)
            {
                await tokenManager.SetCacheAsync(cacheKey, result.Ticket, result.Expires - 300);

                return result.Ticket;
            }

            return ticket;
        }

        /// <summary>
        /// 获得JSSDK Config
        /// </summary>
        /// <param name="pageUrl">应用id</param>
        /// <returns></returns>
        public async Task<WxJSSDKConfig> GetJSSDKConfigAsync(string pageUrl)
        {
            //获得jsapi tiket
            var ticket = await GetJsApiTicketAsync();
            var config = new WxJSSDKConfig()
            {
                ticket = ticket,
                nonceStr = Guid.NewGuid().ToString("N"),
                timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds(),
                configUrl = pageUrl
            };

            //准备签名数据
            var signStr = $"jsapi_ticket={ticket}&noncestr={config.nonceStr}&timestamp={config.timestamp}&url={config.configUrl}";
            //进行签名
            config.signature = SHA1UHelper.Hash(signStr);

            return config;
        }
    }
}
