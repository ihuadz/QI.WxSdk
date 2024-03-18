﻿using Newtonsoft.Json;
using QI.Wx.Sdk.Core;
using QI.Wx.Sdk.PublicAccount;

namespace QI.Wx.Sdk.PublicAccount.Apis.Guide.Dtos
{
    public class GetGuideBuyerRelationResult : ApiResultBase
    {
        /// <summary>
        /// 客户openid
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 客户昵称
        /// </summary>
        [JsonProperty("buyer_nickname")]
        public string BuyerNickName { get; set; }

        /// <summary>
        /// 绑定时间戳
        /// </summary>
        [JsonProperty("create_time")]
        public int CreateTime { get; set; }
    }
}