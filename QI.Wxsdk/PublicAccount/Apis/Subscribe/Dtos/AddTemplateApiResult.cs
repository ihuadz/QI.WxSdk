using Newtonsoft.Json;
using QI.Wx.Sdk.Core;
using QI.Wx.Sdk.PublicAccount;

namespace QI.Wx.Sdk.PublicAccount.Apis.Subscribe.Dtos
{
    /// <summary>
    /// 增加模板返回
    /// </summary>
    public class AddTemplateApiResult : ApiResultBase
    {
        /// <summary>
        /// 添加至帐号下的模板id，发送订阅通知时所需
        /// </summary>
        [JsonProperty("priTmplId")]
        public string PriTmplId { get; set; }
    }
}