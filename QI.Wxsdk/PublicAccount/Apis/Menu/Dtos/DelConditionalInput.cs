using Newtonsoft.Json;

namespace QI.Wx.Sdk.PublicAccount.Apis.Menu.Dtos
{
    public class DelConditionalInput
    {
        /// <summary>
        /// 菜单id
        /// </summary>
        [JsonProperty("menuid")]
        public int MenuId { get; set; }
    }
}