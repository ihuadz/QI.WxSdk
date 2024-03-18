using Newtonsoft.Json;

namespace QI.Wx.Sdk.PublicAccount.Apis.Guide.Dtos
{
    public class NewGuideGroupInput
    {
        /// <summary>
        /// 顾问分组名称
        /// </summary>
        [JsonProperty("group_name")]
        public string GroupName { get; set; }
    }
}