using Newtonsoft.Json;
using System;
using QI.Wx.Sdk.Core;
using QI.Wx.Sdk.PublicAccount;

namespace QI.Wx.Sdk.PublicAccount.Apis.Ticket.Dtos
{
    public class GetTicketApiResult : ApiResultBase
    {
        /// <summary>
        ///     获取到的凭证
        /// </summary>
        [JsonProperty("ticket")]
        public string Ticket { get; set; }

        /// <summary>
        /// 凭证有效时间，单位：秒,默认 7200
        /// </summary>
        [JsonProperty("expires_in")]
        public int Expires { get; set; } = 7200;

        /// <summary>
        /// 凭证过期时间
        /// </summary>
        public DateTime ExporesTime => DateTime.Now.AddSeconds(Expires);
    }
}
