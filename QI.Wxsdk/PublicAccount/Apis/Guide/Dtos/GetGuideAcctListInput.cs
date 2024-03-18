﻿using Newtonsoft.Json;

namespace QI.Wx.Sdk.PublicAccount.Apis.Guide.Dtos
{
    public class GetGuideAcctListInput
    {
        /// <summary>
        /// 分页页数，从0开始
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [JsonProperty("num")]
        public int Num { get; set; }
    }
}