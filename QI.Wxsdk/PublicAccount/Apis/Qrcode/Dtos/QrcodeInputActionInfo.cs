using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace QI.Wx.Sdk.PublicAccount.Apis.Qrcode
{
    /// <summary>
    /// 二维码详细信息
    /// </summary>
    public class QrcodeInputActionInfo
    {
        /// <summary>
        /// 场景信息
        /// </summary>
        [JsonProperty("scene")]
        public QrcodeInputActionInfoScene Scene { get; set; }
    }
}
