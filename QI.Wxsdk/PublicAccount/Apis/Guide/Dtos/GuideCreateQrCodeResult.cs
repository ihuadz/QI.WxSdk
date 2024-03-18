using Newtonsoft.Json;
using QI.Wx.Sdk.Core;
using QI.Wx.Sdk.PublicAccount;

namespace QI.Wx.Sdk.PublicAccount.Apis.Guide.Dtos
{
    public class GuideCreateQrCodeResult : ApiResultBase
    {
        /// <summary>
        /// 点击链接即可下载生成的二维码
        /// </summary>
        [JsonProperty("qrcode_url")]
        public string QrCodeUrl { get; set; }
    }
}