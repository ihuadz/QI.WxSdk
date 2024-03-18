using Microsoft.Extensions.Configuration;

namespace QI.Wx.Sdk
{
    /// <summary>
    /// Wx SDK配置数据，包含微信应用的appid和AppSecret
    /// </summary>
    public class WxConfig
    {

        /// <summary>
        /// configuration
        /// </summary>
        public virtual IConfiguration configuration { get; }

        /// <summary>
        /// Wx上下文对象
        /// </summary>
        /// <param name="configuration"></param>
        public WxConfig(IConfiguration configuration)
        {
            this.configuration = configuration;
            LoadAllFromConfiguration(configuration);
        }

        /// <summary>
        /// 所有的微信应用配置 Dictionary,Key是AppId
        /// </summary>
        public Dictionary<string, WxAppSetting> AllWxAppSetting { get; set; }

        /// <summary>
        /// 根据appid得到应用配置，如果没有找到就返回null
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        public WxAppSetting GetWxAppSetting(string appId)
        {
            return AllWxAppSetting.GetValueOrDefault(appId, null);
        }

        private WxAppSetting _defaultAppSetting;
        /// <summary>
        ///默认应用配置,如果配置中只有一个应用时，才有值
        /// </summary>
        public WxAppSetting DefaultAppSetting => AllWxAppSetting?.Count > 1 ? null : _defaultAppSetting;

        /// <summary>
        /// 从配置中加载所有应用配置
        /// </summary>
        public void LoadAllFromConfiguration(IConfiguration configuration)
        {
            AllWxAppSetting = new Dictionary<string, WxAppSetting>();

            var wechatConfig = configuration.GetSection(ConstWx.WX_CONFIG_KEY_WxAppSetting);
            if (wechatConfig == null) return;

            int index = 0;
            var childConfigs = wechatConfig.GetChildren();
            foreach (var item in childConfigs)
            {
                var appSetting = new WxAppSetting()
                {
                    Name = item[$"Name"],
                    AppId = item[$"AppId"],
                    AppSecret = item[$"AppSecret"]
                };
                int t = 0;
                int.TryParse(item[$"AppType"], out t);
                appSetting.AppType = t;

                //第1个配置
                if (index == 0)
                {
                    _defaultAppSetting = appSetting;
                }

                AllWxAppSetting.Add(appSetting.AppId, appSetting);

                index++;
            }

            if (index > 1) _defaultAppSetting = null;
        }
    }
}
