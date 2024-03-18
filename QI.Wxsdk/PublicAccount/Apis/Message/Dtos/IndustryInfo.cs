using Newtonsoft.Json;

namespace QI.Wx.Sdk.PublicAccount.Apis.Message
{
    public class IndustryInfo
    {
        [JsonProperty("first_class")]
        public string FirstClass { get; set; }

        [JsonProperty("second_class")]
        public string SecondClass { get; set; }


    }
}