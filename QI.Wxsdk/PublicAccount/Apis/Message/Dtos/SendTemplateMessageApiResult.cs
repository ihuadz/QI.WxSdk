using Newtonsoft.Json;
using QI.Wx.Sdk.Core;
using QI.Wx.Sdk.PublicAccount;

namespace QI.Wx.Sdk.PublicAccount.Apis.Message
{
    public class SendTemplateMessageApiResult : ApiResultBase
    {
        [JsonProperty("msgid")]
        public string MessageId { get; set; }
    }
}