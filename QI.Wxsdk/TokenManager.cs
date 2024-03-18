using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QI.Wx.Sdk.GenericApi;
using QI.Wx.Sdk.GenericApi.Dtos;

namespace QI.Wx.Sdk;

/// <summary>
/// 微信Token管理器, 生命周期为Scope
/// 负责AccessToken的获取\缓存
/// </summary>
public class TokenManager : ITokenManager
{
    /// <summary>
    /// configuration
    /// </summary>
    protected WxConfig wxConfig;

    /// <summary>
    /// IServiceProvider
    /// </summary>
    protected IServiceProvider serviceProvider;

    /// <summary>
    /// 缓存管理对象
    /// </summary>
    protected virtual IDistributedCache cache { get; }

    /// <summary>
    /// 微信AccessToken管理器,如果只配置了一个应用,则默认使用它
    /// </summary>
    /// <param name="wxConfig"></param>
    /// <param name="serviceProvider"></param>
    public TokenManager(WxConfig wxConfig
        , IServiceProvider serviceProvider)
    {
        this.wxConfig = wxConfig;
        this.serviceProvider = serviceProvider;

        cache = GetService<IDistributedCache>();

        CurApp = wxConfig.DefaultAppSetting;
    }


    /// <summary>
    /// 当前应用
    /// </summary>
    public virtual WxAppSetting CurApp { get; set; }

    /// <summary>
    /// 当前应用
    /// </summary>
    /// <returns></returns>
    public virtual WxAppSetting GetCurApp()
    {
        return CurApp;
    }

    /// <summary>
    /// 检查应用配置数据
    /// </summary>
    protected virtual void CheckAppSetting()
    {
        if (CurApp == null) throw new WxException("应用配置不能空");
        if (string.IsNullOrEmpty(CurApp.AppId)) throw new WxException("应用AppId能空");
        if (string.IsNullOrEmpty(CurApp.AppSecret)) throw new WxException("应用AppSecret能空");
    }

    /// <summary>
    /// 获取Access Token
    /// </summary>
    /// <remarks>如果可能,会进行缓存</remarks>
    /// <returns></returns>
    public virtual async Task<string> GetAccessTokenAsync()
    {   
        CheckAppSetting();

        //获取token,先查询缓存
        string token = await GetAccessTokenFromCacheAsync();
        if (!string.IsNullOrEmpty(token)) return token;

        //如果缓存中没有，调用Wx Api获取Token
        IWxTokenApi tokenApi = GetService<IWxTokenApi>();
        TokenApiResult result = await tokenApi.GetAsync(CurApp.AppId, CurApp.AppSecret);

        //缓存token
        await SetAccessTokenToCacheAsync(result.AccessToken, result.Expires);

        return result.AccessToken;
    }

    /// <summary>
    /// 获得Wx管理对象
    /// </summary>
    /// <returns></returns>
    public virtual WxConfig GetWxConfig()
    {
        return wxConfig;
    }

    /// <summary>
    /// 清除当前缓存的AccessToken
    /// </summary>
    /// <returns></returns>
    public virtual async Task ClearAccessTokenAsync()
    {
        var cacheKey = GenerateCacheKey(GetCurAppId());
        await RemoveCacheAsync(cacheKey);

    }

    /// <summary>
    /// 得到会话当前AppId
    /// </summary>
    /// <returns></returns>
    public virtual string GetCurAppId()
    {
        return CurApp?.AppId ?? string.Empty;
    }

    /// <summary>
    /// 设置当前的应用
    /// </summary>
    /// <param name="wxApp"></param>
    public virtual void SetCurApp(WxAppSetting wxApp)
    {
        CurApp = wxApp;
        CheckAppSetting();
    }

    /// <summary>
    /// 设置当前的应用,根据Appid从WxContext中查找
    /// </summary>
    /// <param name="appId"></param>
    public virtual void SetCurApp(string appId)
    {
        CurApp = wxConfig.GetWxAppSetting(appId);
        CheckAppSetting();
    }

    /// <summary>
    /// 重新到微信服务器获取AccessToken，然后进行缓存
    /// </summary>
    /// <returns></returns>
    public async Task<string> GetNewAccessTokenAsync()
    {
        CheckAppSetting();

        //调用Wx Api获取Token
        IWxTokenApi tokenApi = GetService<IWxTokenApi>();
        TokenApiResult result = await tokenApi.GetAsync(CurApp.AppId, CurApp.AppSecret);

        //缓存token
        await SetAccessTokenToCacheAsync(result.AccessToken, result.Expires);

        return result.AccessToken;
    }


    /// <summary>
    /// 生成缓存Key
    /// </summary>
    /// <param name="appId"></param>
    protected virtual string GenerateCacheKey(string appId)
    {
        return $"{ConstWx.WX_CACHE_AccessToken}:{appId}";
    }

    /// <summary>
    /// 从缓存中读取accessToken
    /// </summary>
    /// <returns></returns>
    protected virtual async Task<string> GetAccessTokenFromCacheAsync()
    {
        var cacheKey = GenerateCacheKey(CurApp.AppId);
        return await GetCacheAsync(cacheKey); 
    }

    /// <summary>
    /// 把accessToken缓存起来
    /// </summary>
    /// <param name="accessToken"></param>
    /// <param name="expiresSeconds"></param>
    /// <returns></returns>
    protected virtual async Task SetAccessTokenToCacheAsync(string accessToken, int expiresSeconds = 7200)
    {
        //缓存token
        var cacheKey = GenerateCacheKey(CurApp.AppId);
        var cacheSeconds = expiresSeconds - 300;
        if (cacheSeconds <= 0)
           await RemoveCacheAsync(cacheKey);
        else
           await SetCacheAsync(cacheKey, accessToken, cacheSeconds);
    }

    /// <summary>
    /// 直接设置一个AccessToken，并进行缓存
    /// </summary>
    /// <param name="accessToken">accessToken</param>
    /// <param name="expiresSeconds">accessToken过期时间，默认为7200</param>
    /// <returns></returns>
    public virtual async  Task SetAccessTokenAsync(string accessToken, int expiresSeconds = 7200)
    {
        //缓存token
        await SetAccessTokenToCacheAsync(accessToken, expiresSeconds);
    }


    /// <summary>
    /// 得到服务对象
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public virtual T GetService<T>()
    {
        return serviceProvider.GetService<T>();
    }

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
    public virtual async Task SetCacheAsync(string cacheKey, string value, int cacheSeconds)
    {
        if (cache == null) return;

        await cache.SetStringAsync(cacheKey, value, new DistributedCacheEntryOptions()
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(cacheSeconds)
        });
    }

    /// <summary>
    /// 获得缓存数据,使用 IDistributedCache
    /// </summary>
    /// <param name="cacheKey"></param>
    /// <returns></returns>
    public virtual async Task<string> GetCacheAsync(string cacheKey)
    {
        if (cache == null) return string.Empty;

        return await cache.GetStringAsync(cacheKey);
    }

    /// <summary>
    /// 清除缓存数据
    /// </summary>
    /// <param name="cacheKey"></param>
    /// <returns></returns>
    public virtual async Task RemoveCacheAsync(string cacheKey)
    {
        if (cache == null) return;

        await cache.RemoveAsync(cacheKey);
    }

}