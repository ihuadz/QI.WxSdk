using Newtonsoft.Json;
using QI.Wx.Sdk.Core;

namespace QI.Wx.Sdk.GenericApi.Dtos
{
    /// <summary>
    /// 获取access_token返回值
    /// </summary>
    public class TokenApiResult : ApiResultBase
    {
        /// <summary>
        ///     获取到的凭证
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        ///     凭证有效时间，单位：秒
        /// </summary>
        [JsonProperty("expires_in")]
        public int Expires { get; set; } = 0;

        /// <summary>
        ///     凭证过期时间
        /// </summary>
        public DateTime ExpiresTime => DateTime.Now.AddSeconds(Expires);
    }
}