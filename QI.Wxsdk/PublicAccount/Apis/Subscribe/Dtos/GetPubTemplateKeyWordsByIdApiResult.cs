using Newtonsoft.Json;
using System.Collections.Generic;
using QI.Wx.Sdk.Core;
using QI.Wx.Sdk.PublicAccount;

namespace QI.Wx.Sdk.PublicAccount.Apis.Subscribe.Dtos
{
    /// <summary>
    /// 得到模板关键词返回
    /// </summary>
    public class GetPubTemplateKeyWordsByIdApiResult : ApiResultBase
    {
        [JsonProperty("data")]
        public IEnumerable<PubTemplateKeyWordsDataInfo> Data { get; set; }
    }

    /// <summary>
    /// 模板关键词数据
    /// </summary>
    public class PubTemplateKeyWordsDataInfo
    {
        /// <summary>
        /// 关键词 id，选用模板时需要
        /// </summary>
        [JsonProperty("kid")]
        public int Kid { get; set; }

        /// <summary>
        /// 关键词内容
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 关键词内容对应的示例
        /// </summary>
        [JsonProperty("example")]
        public string Example { get; set; }

        /// <summary>
        /// 参数类型
        /// </summary>
        [JsonProperty("rule")]
        public string Rule { get; set; }
    }
}