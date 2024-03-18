using Newtonsoft.Json;
using System.Collections.Generic;
using QI.Wx.Sdk.Core;
using QI.Wx.Sdk.PublicAccount;

namespace QI.Wx.Sdk.PublicAccount.Apis.Subscribe.Dtos
{
    /// <summary>
    /// 得到类目返回
    /// </summary>
    public class GetCategoryApiResult : ApiResultBase
    {
        [JsonProperty("data")]
        public IEnumerable<CategoryDataInfo> Data { get; set; }
    }

    /// <summary>
    /// 类目数据
    /// </summary>
    public class CategoryDataInfo
    {
        /// <summary>
        /// 类目id，查询公共模板库时需要
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// 类目的中文名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}