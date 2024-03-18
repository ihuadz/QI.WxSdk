using Newtonsoft.Json;
using QI.Wx.Sdk.Core;
using QI.Wx.Sdk.PublicAccount;

namespace QI.Wx.Sdk.PublicAccount.Apis.User.Dtos
{
    public class GetIdListApiResult : ApiResultBase
    {
        /// <summary>
        /// 被置上的标签列表
        /// </summary>
        [JsonProperty("tagid_list")]
        public int[] TagIdList { get; set; }
    }
}