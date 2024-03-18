using Newtonsoft.Json;
using System.Collections.Generic;

namespace QI.Wx.Sdk.PublicAccount.Apis.Menu
{
    public class CreateMenuInput
    {
        [JsonProperty("button")]
        public List<MenuButtonBase> Button { get; set; }
    }
}