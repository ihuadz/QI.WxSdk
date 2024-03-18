using Newtonsoft.Json;

namespace QI.Wx.Sdk.PublicAccount.Apis.KfAccount.Dtos
{
    public class DelKfAccountInput
    {
        [JsonProperty("kf_account")]
        public string Account { get; set; }
    }
}