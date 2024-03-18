using Newtonsoft.Json;

namespace QI.Wx.Sdk.PublicAccount.Apis.Subscribe.Dtos
{
    /// <summary>
    /// 删除模板输入
    /// </summary>
    public class DeleteTemplateInput
    {
        /// <summary>
        /// 要删除的模板id
        /// </summary>
        [JsonProperty("priTmplId")]
        public string PriTmplId { get; set; }
    }
}