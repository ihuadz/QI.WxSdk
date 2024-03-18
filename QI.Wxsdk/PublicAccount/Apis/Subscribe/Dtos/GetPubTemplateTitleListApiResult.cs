using Newtonsoft.Json;
using System.Collections.Generic;
using QI.Wx.Sdk.Core;
using QI.Wx.Sdk.PublicAccount;

namespace QI.Wx.Sdk.PublicAccount.Apis.Subscribe.Dtos
{
    /// <summary>
    /// 得到模板标题列表返回
    /// </summary>
    public class GetPubTemplateTitleListApiResult : ApiResultBase
    {
        [JsonProperty("data")]
        public IEnumerable<PubTemplateTitleDataInfo> Data { get; set; }
    }

    /// <summary>
    /// 模板标题数据
    /// </summary>
    public class PubTemplateTitleDataInfo
    {
        /// <summary>
        /// 模版标题 id
        /// </summary>
        [JsonProperty("tid")]
        public int Tid { get; set; }

        /// <summary>
        /// 模版标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 模版类型，2 为一次性订阅，3 为长期订阅
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        /// 模版所属类目 id
        /// </summary>
        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }
    }
}