namespace QI.Wx.Sdk
{
    /// <summary>
    /// 微信Token管理器, 生命周期为Scope
    /// 负责AccessToken的获取\缓存
    /// </summary>
    public interface ITokenManager
    {
        /// <summary>
        /// 得到WxConfig
        /// </summary>
        /// <returns></returns>
        WxConfig GetWxConfig();

        /// <summary>
        /// 得到会话当前AppId
        /// </summary>
        /// <returns></returns>
        string GetCurAppId();

        /// <summary>
        /// 得到当前的应用配置信息
        /// </summary>
        WxAppSetting GetCurApp();

        /// <summary>
        /// 设置当前的应用
        /// </summary>
        /// <param name="wxApp"></param>
        void SetCurApp(WxAppSetting wxApp);

        /// <summary>
        /// 设置当前的应用,根据Appid从WxContext中查找
        /// </summary>
        /// <param name="appId"></param>
        void SetCurApp(string appId);

        /// <summary>
        /// 获取会话的全局访问AccessToken
        /// </summary>
        /// <remarks>如果可能,会进行缓存</remarks>
        /// <returns></returns>
        Task<string> GetAccessTokenAsync();

        /// <summary>
        /// 重新到微信服务器获取AccessToken，并进行缓存
        /// </summary>
        /// <returns></returns>
        Task<string> GetNewAccessTokenAsync();

        /// <summary>
        /// 直接设置一个AccessToken，并进行缓存
        /// </summary>
        /// <param name="accessToken">accessToken</param>
        /// <param name="expiresSeconds">accessToken过期时间，默认为7200</param>
        /// <returns></returns>
        Task SetAccessTokenAsync(string accessToken,int expiresSeconds = 7200);

        /// <summary>
        /// 清除当前缓存的AccessToken
        /// </summary>
        /// <returns></returns>
        Task ClearAccessTokenAsync();

        /// <summary>
        /// 得到服务对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetService<T>();

        /// <summary>
        /// 设置缓存,使用 IDistributedCache
        /// </summary>
        /// <remarks>
        /// 需要先注册IDistributedCache，如果没有注册，则忽略缓存操作
        /// </remarks>
        /// <param name="cacheKey"></param>
        /// <param name="value"></param>
        /// <param name="cacheSeconds"></param>
        /// <returns></returns>
        Task SetCacheAsync(string cacheKey, string value, int cacheSeconds);

        /// <summary>
        /// 获得缓存数据,使用 IDistributedCache
        /// </summary>
        /// <param name="cacheKey"></param>
        /// <returns></returns>
        Task<string> GetCacheAsync(string cacheKey);

        /// <summary>
        /// 清除缓存数据
        /// </summary>
        /// <param name="cacheKey"></param>
        /// <returns></returns>
        Task RemoveCacheAsync(string cacheKey);
    }
}