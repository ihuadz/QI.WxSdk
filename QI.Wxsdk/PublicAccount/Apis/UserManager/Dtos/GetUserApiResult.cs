using Newtonsoft.Json;
using QI.Wx.Sdk.Core;
using QI.Wx.Sdk.PublicAccount;

namespace QI.Wx.Sdk.PublicAccount.Apis.User.Dtos
{
    public class GetUserApiResult : ApiResultBase
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("data")]
        public DataModel Data { get; set; }

        [JsonProperty("next_openid")]
        public string NextOpenId { get; set; }

        public class DataModel
        {
            [JsonProperty("openid")]
            public string[] OpenIds { get; set; }
        }
    }
}