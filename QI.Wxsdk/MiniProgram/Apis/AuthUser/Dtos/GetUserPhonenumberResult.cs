using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QI.Wx.Sdk.Core;

namespace QI.Wx.Sdk.MiniProgram.Apis.AuthUser.Dtos
{
    /// <summary>
    /// 获得手机号返回
    /// </summary>
    public class GetUserPhonenumberResult : ApiResultBase
    {
        /// <summary>
        /// 手机信息
        /// </summary>
        [JsonProperty("phone_info")]
        public PhoneInfo PhoneInfo { get; set; }
    }

    /// <summary>
    /// 手机信息
    /// </summary>
    public class PhoneInfo
    {
        /// <summary>
        /// 用户绑定的手机号（国外手机号会有区号）
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 没有区号的手机号
        /// </summary>
        public string PurePhoneNumber { get; set; }

        /// <summary>
        /// 区号
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// 数据水印
        /// </summary>
        [JsonProperty("watermark")]
        public WaterMark WaterMark { get; set; }
    }

    /// <summary>
    /// 数据水印
    /// </summary>
    public class WaterMark
    {
        /// <summary>
        /// 用户获取手机号操作的时间戳
        /// </summary>
        public int Ttimestamp { get; set; }

        /// <summary>
        /// 小程序appid
        /// </summary>
        public string Appid { get; set; }
    }

}
