using Newtonsoft.Json;

namespace QI.Wx.Sdk.PublicAccount.Apis.Menu.Dtos
{
    public class TryMatchInput
    {
        /// <summary>
        /// user_id可以是粉丝的OpenID，也可以是粉丝的微信号。
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}