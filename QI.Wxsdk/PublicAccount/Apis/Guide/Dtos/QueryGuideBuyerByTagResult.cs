using Newtonsoft.Json;
using System.Collections.Generic;
using QI.Wx.Sdk.Core;
using QI.Wx.Sdk.PublicAccount;

namespace QI.Wx.Sdk.PublicAccount.Apis.Guide.Dtos
{
    public class QueryGuideBuyerByTagResult : ApiResultBase
    {
        /// <summary>
        /// 客户openid列表
        /// </summary>
        [JsonProperty("openid_list")]
        public List<string> OpenIdList { get; set; }
    }
}