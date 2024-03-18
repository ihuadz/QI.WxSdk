using Microsoft.Extensions.DependencyInjection;
using QI.Wx.Sdk.GenericApi;
using QI.Wx.Sdk.MiniProgram;
using QI.Wx.Sdk.MiniProgram.Apis;
using QI.Wx.Sdk.PublicAccount;
using QI.Wx.Sdk.PublicAccount.Apis;

namespace QI.Wx.Sdk
{
    /// <summary>
    /// 方法扩展
    /// </summary>
    public static class Extentions
    {
        /// <summary>
        /// 添加WxSdk 接口、服务,IWxSession会话
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddWxSdkAll(this IServiceCollection services)
        {
            //注册接口，服务
            services.AddWxSdkApiAndServices();
            //注册token管理器
            services.AddWxSdkTokenManager();

            return services;
        }

        /// <summary>
        /// 注册token管理器,会话服务
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddWxSdkTokenManager(this IServiceCollection services)
        {
            //添加WxSession
            services.AddScoped<ITokenManager, TokenManager>();

            return services;
        }

        /// <summary>
        /// 添加WxSdk 接口、服务
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddWxSdkApiAndServices(this IServiceCollection services)
        {
            services
                .AddWebApiClient()
                .UseJsonFirstApiActionDescriptor();

            //添加Wx上下文
            services.AddSingleton<WxConfig>();

            //添加微信API映射
            //公众接口
            services.AddHttpApi<IWxTokenApi>();

            //公众号接口
            services.AddHttpApi<IWxPaAuthUserApi>();
            services.AddHttpApi<IWxPaMessageTemplateApi>();
            services.AddHttpApi<IWxPaMenuApi>();
            services.AddHttpApi<IWxPaKfAccountApi>();
            services.AddHttpApi<IWxPaMediaApi>();
            services.AddHttpApi<IWxPaUserManagerApi>();
            services.AddHttpApi<IWxPaTagsApi>();
            services.AddHttpApi<IWxPaSubscribeApi>();
            services.AddHttpApi<IWxPaGuideApi>();
            services.AddHttpApi<IWxPaTicketApi>();
            services.AddHttpApi<IWxPaQrcodeApi>();

            //注册聚合/扩展服务 -公众号
            services.AddScoped<WxPaApiService>();

            //小程序接口
            services.AddHttpApi<IWxMpAuthUserApi>();
            services.AddHttpApi<IWxMpUrllinkApi>();
            services.AddHttpApi<IWxMpQRCodeApi>();
            services.AddHttpApi<IWxMpMessageApi>();

            //注册聚合/扩展服务 -小程序
            services.AddScoped<WxMpApiService>();

            return services;
        }

        /// <summary>
        /// 转换为Base64,如果bytes为空则返回""
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string ToBase64(this byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
            {
                return string.Empty;
            }

            return Convert.ToBase64String(bytes);
        }
    }
}