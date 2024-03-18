using Microsoft.Extensions.DependencyInjection;
using WebApiClientCore;

namespace QI.Wx.Sdk.Core
{
    /// <summary>
    /// WebApiClient过滤器,自动设置url的access_token请求参数
    /// </summary>
    public class AccessTokenApiFilter : ApiFilterAttribute
    {
        /// <summary>
        /// 请求
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override async Task OnRequestAsync(ApiRequestContext context)
        {
            var tokenManager = context.HttpContext.ServiceProvider.GetRequiredService<ITokenManager>();
            string accessToken = await tokenManager.GetAccessTokenAsync();
            //accessToken = "59___3IsRuVuqQraOoc6_fA97njhbJY4AsPWXb-uc-QbpqEDwiJ5ZlzWwaS08zvnbbSMKxGPRwzTGd_u6FtFMq5C38NKj-Uaf5omWvS-OBY4y77l0CB4DVgkCk4J8PKFEtQgUmRd3W5VAoQxJ0PLJXaAIAGES";
            context.HttpContext.RequestMessage.AddUrlQuery("access_token", accessToken);
        }

        /// <summary>
        /// 响应
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task OnResponseAsync(ApiResponseContext context)
        {
            if(context.Result is ApiResultBase apiResult && apiResult!=null)
            {
                //如果请求的accesstoken过期，清除当前缓存的过期token
                if (apiResult.IsAccessTokenInvalid)
                {
                    var tokenManager = context.HttpContext.ServiceProvider.GetRequiredService<ITokenManager>();
                    tokenManager.ClearAccessTokenAsync();
                }
            }

            return Task.CompletedTask;
        }
    }
}
