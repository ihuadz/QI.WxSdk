using Newtonsoft.Json;

namespace QI.Wx.Sdk.PublicAccount.Apis.Guide.Dtos
{
    public class GetGuideBuyerRelationByBuyerInput
    {
        /// <summary>
        /// 客户openid
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }
    }
}