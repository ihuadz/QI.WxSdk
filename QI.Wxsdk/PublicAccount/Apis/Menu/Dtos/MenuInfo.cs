using Newtonsoft.Json;
using System.Collections.Generic;

namespace QI.Wx.Sdk.PublicAccount.Apis.Menu
{
    /// <summary>
    /// 菜单信息
    /// </summary>
    public class MenuInfo
    {
        [JsonProperty("button")]
        public List<MenuButtonBase> Button { get; set; }
    }
}