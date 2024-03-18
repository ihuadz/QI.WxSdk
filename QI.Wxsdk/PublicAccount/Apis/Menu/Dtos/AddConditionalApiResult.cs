using Newtonsoft.Json;

namespace QI.Wx.Sdk.PublicAccount.Apis.Menu
{
    public class AddConditionalApiResult
    {
        [JsonProperty("menuid")]
        public string MenuId { get; set; }
    }
}