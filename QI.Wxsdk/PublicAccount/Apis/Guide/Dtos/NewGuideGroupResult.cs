using Newtonsoft.Json;
using QI.Wx.Sdk.Core;
using QI.Wx.Sdk.PublicAccount;

namespace QI.Wx.Sdk.PublicAccount.Apis.Guide.Dtos
{
    public class NewGuideGroupResult : ApiResultBase
    {
        /// <summary>
        /// 顾问分组唯一id
        /// </summary>
        [JsonProperty("group_id")]
        public long GroupId { get; set; }
    }
}