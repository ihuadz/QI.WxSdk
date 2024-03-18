using Newtonsoft.Json;
using QI.Wx.Sdk.Core;
using QI.Wx.Sdk.PublicAccount;

namespace QI.Wx.Sdk.PublicAccount.Apis.Guide.Dtos
{
    public class GetGuideMassendJobResult : ApiResultBase
    {
        /// <summary>
        /// 群发任务
        /// </summary>
        [JsonProperty("job")]
        public GuideMassendJobListInfo Job { get; set; }
    }
}