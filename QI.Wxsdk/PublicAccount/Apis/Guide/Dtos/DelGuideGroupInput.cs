using Newtonsoft.Json;

namespace QI.Wx.Sdk.PublicAccount.Apis.Guide.Dtos
{
    public class DelGuideGroupInput
    {
        /// <summary>
        /// 顾问分组id
        /// </summary>
        [JsonProperty("group_id")]
        public long GroupId { get; set; }
    }
}