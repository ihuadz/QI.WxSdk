using Newtonsoft.Json;
using QI.Wx.Sdk.Core;
using QI.Wx.Sdk.PublicAccount;

namespace QI.Wx.Sdk.PublicAccount.Apis.Guide.Dtos
{
    public class GetGuideBuyerDisplayTagResult : ApiResultBase
    {
        /// <summary>
        /// 展示标签值
        /// </summary>
        [JsonProperty("display_tag_list")]
        public string DisplayTagList { get; set; }
    }
}