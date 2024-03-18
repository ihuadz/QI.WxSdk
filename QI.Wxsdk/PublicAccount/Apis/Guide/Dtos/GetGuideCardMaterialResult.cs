using Newtonsoft.Json;
using System.Collections.Generic;
using QI.Wx.Sdk.Core;
using QI.Wx.Sdk.PublicAccount;

namespace QI.Wx.Sdk.PublicAccount.Apis.Guide.Dtos
{
    public class GetGuideCardMaterialResult : ApiResultBase
    {
        /// <summary>
        /// 小程序卡片素材列表
        /// </summary>
        [JsonProperty("card_list")]
        public List<GuideCardMaterialInfo> CardList { get; set; }
    }

    public class GuideCardMaterialInfo
    {
        /// <summary>
        /// 卡片名字
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 小程序appid
        /// </summary>
        [JsonProperty("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 路径
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }

        /// <summary>
        /// 图片链接
        /// </summary>
        [JsonProperty("picurl")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 图片id
        /// </summary>
        [JsonProperty("master_id")]
        public int MasterId { get; set; }

        /// <summary>
        /// 图片id
        /// </summary>
        [JsonProperty("slave_id")]
        public int SlaveId { get; set; }
    }
}