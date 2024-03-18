using Newtonsoft.Json;

namespace QI.Wx.Sdk.PublicAccount.Apis.Guide.Dtos
{
    public class GetGuideCardMaterialInput
    {
        /// <summary>
        /// 操作类型，填0，表示服务号素材
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }
    }
}