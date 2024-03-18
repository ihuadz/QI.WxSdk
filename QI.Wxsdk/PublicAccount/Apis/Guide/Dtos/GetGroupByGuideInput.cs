using Newtonsoft.Json;

namespace QI.Wx.Sdk.PublicAccount.Apis.Guide.Dtos
{
    public class GetGroupByGuideInput
    {
        /// <summary>
        /// 顾问微信号
        /// </summary>
        [JsonProperty("guide_account")]
        public string GuideAccount { get; set; }
    }
}