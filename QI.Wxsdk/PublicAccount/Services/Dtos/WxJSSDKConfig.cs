using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QI.Wx.Sdk.PublicAccount.Services.Dtos
{
    /// <summary>
    /// 微信JSSDK配置参数，返回给前端
    /// </summary>
    public class WxJSSDKConfig
    {
        /// <summary>
        /// ticket
        /// </summary>
        public string ticket { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        public long timestamp { get; set; }

        /// <summary>
        /// 随机字符
        /// </summary>
        public string nonceStr { get; set; }

        /// <summary>
        /// SHA1签名
        /// </summary>
        public string signature { get; set; }

        /// <summary>
        /// 签名页面地址
        /// </summary>
        public string configUrl { get; set; }

    }
}
