using Newtonsoft.Json;
using System.Collections.Generic;
using QI.Wx.Sdk.Core;
using QI.Wx.Sdk.PublicAccount;

namespace QI.Wx.Sdk.PublicAccount.Apis.Guide.Dtos
{
    public class GetGuideTagOptionResult : ApiResultBase
    {
        /// <summary>
        /// 标签类型列表
        /// </summary>
        [JsonProperty("options")]
        public List<OptionsInfo> Options { get; set; }
    }

    public class OptionsInfo
    {
        /// <summary>
        /// 标签类型名字
        /// </summary>
        [JsonProperty("tag_name")]
        public string TagName { get; set; }

        /// <summary>
        /// 标签类型可选值
        /// </summary>
        [JsonProperty("tag_values")]
        public List<string> TagValues { get; set; }
    }
}