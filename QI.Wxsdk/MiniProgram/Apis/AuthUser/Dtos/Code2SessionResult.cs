using Newtonsoft.Json;
using QI.Wx.Sdk.Core;

namespace QI.Wx.Sdk.MiniProgram.Apis.AuthUser.Dtos
{
    /// <summary>
    /// 通过code获得OpenId和SessionKey的返回值
    /// </summary>
    public class Code2SessionResult : ApiResultBase
    {
        /// <summary>
        ///  会话密钥
        /// </summary>
        [JsonProperty("session_key")]
        public string SessionKey { get; set; }


        /// <summary>
        ///     用户的标识，对当前小程序唯一
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户在开放平台的唯一标识符，若当前小程序已绑定到微信开放平台帐号下会返回.
        /// https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/union-id.html
        /// </summary>
        [JsonProperty("unionid")]
        public string UnionId { get; set; }
    }
}
