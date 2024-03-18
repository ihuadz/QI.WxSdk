using Newtonsoft.Json;

namespace QI.Wx.Sdk.PublicAccount.Apis.User.Dtos
{
    public class GetIdListInput
    {
        [JsonProperty("openid")]
        public string OpenId { get; set; }
    }
}