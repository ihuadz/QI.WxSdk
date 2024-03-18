using Newtonsoft.Json;
using System.Collections.Generic;
using QI.Wx.Sdk.Core;
using QI.Wx.Sdk.PublicAccount;

namespace QI.Wx.Sdk.PublicAccount.Apis.Subscribe.Dtos
{
    /// <summary>
    /// 得到模块列表返回
    /// </summary>
    public class GetTemplateListApiResult : ApiResultBase
    {
        [JsonProperty("data")]
        public IEnumerable<TemplateDataInfo> Data { get; set; }
    }

    /// <summary>
    /// 模板数据
    /// </summary>
    public class TemplateDataInfo
    {
        /// <summary>
        /// 添加至帐号下的模板 id，发送订阅通知时所需
        /// </summary>
        [JsonProperty("priTmplId")]
        public string PriTmplId { get; set; }

        /// <summary>
        /// 模版标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 模版内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 模板内容示例
        /// </summary>
        [JsonProperty("example")]
        public string Example { get; set; }

        /// <summary>
        /// 模版类型，2 为一次性订阅，3 为长期订阅
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }
    }
}