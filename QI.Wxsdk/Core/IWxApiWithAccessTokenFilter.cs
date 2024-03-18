using WebApiClientCore.Attributes;

namespace QI.Wx.Sdk.Core
{
    /// <summary>
    /// WebApiClient过滤器,自动设置url的access_token请求参数
    /// </summary>
    [JsonNetReturn(EnsureMatchAcceptContentType = false)]
    [AccessTokenApiFilter]
    public interface IWxApiWithAccessTokenFilter
    {
    }
}
