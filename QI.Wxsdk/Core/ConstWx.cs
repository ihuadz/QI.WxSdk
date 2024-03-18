namespace QI.Wx.Sdk.Core
{
    /// <summary>
    /// 一些常量
    /// </summary>
    public class ConstWx
    {
        /// <summary>
        /// WxAppSettin配置Key
        /// </summary>
        public const string WX_CONFIG_KEY_WxAppSetting = "WeixinSetting:App";

        /// <summary>
        /// token 缓存命名空间
        /// </summary>
        public const string WX_CACHE_AccessToken = "WX:ACCESS_TOKEN";

        /// <summary>
        /// JsApi Ticket CacheKey
        /// </summary>
        public const string WX_CACHE_JsApiTicket = "WX:JSAPI_TICKET";

        /// <summary>
        /// 小程序版本 正式版
        /// 用于生成二维码
        /// </summary>
        public const string MP_Env_Ver_Release = "release";

        /// <summary>
        /// 小程序版本 体验版
        /// 用于生成二维码
        /// </summary>
        public const string MP_Env_Ver_Trial = "trial";

        /// <summary>
        /// 小程序版本 开发版
        /// 用于生成二维码
        /// </summary>
        public const string MP_Env_Ver_Develop = "develop";

        /// <summary>
        /// 小程序版本 正式版
        /// 用于发送订阅消息
        /// </summary>
        public const string MP_Env_Ver_Release2 = "formal";

        /// <summary>
        /// 小程序版本 体验版
        /// 用于发送订阅消息
        /// </summary>
        public const string MP_Env_Ver_Trial2 = "trial";

        /// <summary>
        /// 小程序版本 开发版
        /// 用于发送订阅消息
        /// </summary>
        public const string MP_Env_Ver_Develop2 = "developer";

        /// <summary>
        /// 小程序语言en_US
        /// </summary>
        public const string MP_Language_en_US = "en_US";

        /// <summary>
        /// 小程序语言zh_TW
        /// </summary>
        public const string MP_Language_zh_TW = "zh_TW";

        /// <summary>
        /// 小程序语言zh_HK
        /// </summary>
        public const string MP_Language_zh_HK = "zh_HK";

        /// <summary>
        /// 小程序语言zh_CN
        /// </summary>
        public const string MP_Language_zh_CN = "zh_CN";
    }
}
