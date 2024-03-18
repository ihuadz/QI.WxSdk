using Newtonsoft.Json;
using System.Collections.Generic;
using QI.Wx.Sdk.Core;
using QI.Wx.Sdk.PublicAccount;

namespace QI.Wx.Sdk.PublicAccount.Apis.Guide.Dtos
{
    public class GetGroupByGuideResult : ApiResultBase
    {
        /// <summary>
        /// 顾问分组列表
        /// </summary>
        [JsonProperty("group_id_list")]
        public List<long> GroupIdList { get; set; }
    }
}