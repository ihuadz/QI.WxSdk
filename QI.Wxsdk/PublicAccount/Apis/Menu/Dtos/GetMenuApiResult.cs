using Newtonsoft.Json;
using QI.Wx.Sdk.Core;
using QI.Wx.Sdk.PublicAccount;

namespace QI.Wx.Sdk.PublicAccount.Apis.Menu
{
    public class GetMenuApiResult : ApiResultBase
    {
        /// <summary>
        /// 默认菜单
        /// </summary>
        [JsonProperty("menu")]
        public GetMenuInfo Menu { get; set; }

        /// <summary>
        /// 个性化菜单列表
        /// </summary>
        [JsonProperty("conditionalmenu")]
        public GetConditionalMenuInfo ConditionalMenu { get; set; }
    }

    public class GetMenuInfo : MenuInfo
    {
        /// <summary>
        /// 此字段有个性化菜单时 有值
        /// </summary>
        [JsonProperty("MenuId")]
        public int menuid { get; set; }
    }

    public class GetConditionalMenuInfo : ConditionalMenuInfo
    {
        /// <summary>
        /// 此字段有个性化菜单时 有值
        /// </summary>
        [JsonProperty("MenuId")]
        public int menuid { get; set; }
    }
}