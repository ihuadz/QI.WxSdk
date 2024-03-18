using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QI.Wx.Sdk.Core
{
    /// <summary>
    /// Wx接口聚合服务 基类
    /// </summary>
    public class WxApiServiceBase
    {
        /// <summary>
        /// 微信接口集合服务
        /// </summary>
        /// <param name="tokenManager"></param>
        public WxApiServiceBase(ITokenManager tokenManager)
        {
            TokenManager = tokenManager;
        }

        /// <summary>
        /// 微信AccessToken管理器
        /// </summary>
        public virtual ITokenManager TokenManager { get; }

        /// <summary>
        /// 得到服务对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        protected virtual T GetService<T>()
        {
            return TokenManager.GetService<T>();
        }

        /// <summary>
        /// 设置当前的应用
        /// </summary>
        /// <param name="wxApp"></param>
        public virtual void SetCurApp(WxAppSetting wxApp)
        {
            TokenManager.SetCurApp(wxApp);
        }


        /// <summary>
        /// 设置当前的应用,根据Appid从WxContext中查找
        /// </summary>
        /// <param name="appId"></param>
        public virtual void SetCurApp(string appId)
        {
            TokenManager.SetCurApp(appId);
        }

        /// <summary>
        /// 得到会话当前AppId
        /// </summary>
        /// <returns></returns>
        public virtual string GetCurAppId()
        {
            return TokenManager?.GetCurAppId() ?? string.Empty;
        }

        /// <summary>
        /// 当前应用
        /// </summary>
        /// <returns></returns>
        public virtual WxAppSetting GetCurApp()
        {
            return TokenManager.GetCurApp();
        }
    }
}
