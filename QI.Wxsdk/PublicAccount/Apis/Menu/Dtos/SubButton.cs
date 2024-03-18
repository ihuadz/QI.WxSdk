﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace QI.Wx.Sdk.PublicAccount.Apis.Menu
{
    //二级菜单
    public class SubButton
    {
        /// <summary>
        ///     二级菜单列表
        /// </summary>
        [JsonProperty(PropertyName = "list")]
        public List<MenuButtonBase> List { get; set; }
    }
}