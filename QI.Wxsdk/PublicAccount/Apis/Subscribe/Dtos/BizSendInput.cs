using Newtonsoft.Json;
using System.Collections.Generic;

namespace QI.Wx.Sdk.PublicAccount.Apis.Subscribe.Dtos
{
    /// <summary>
    /// 发送订阅通知输入
    /// </summary>
    public class BizSendInput
    {
        /// <summary>
        /// 接收者（用户）的 openid
        /// </summary>
        [JsonProperty("touser")]
        public string ToUser { get; set; }

        /// <summary>
        /// 所需下发的订阅模板id
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 跳转网页时填写
        /// </summary>
        [JsonProperty("page")]
        public string Page { get; set; }

        /// <summary>
        /// 跳转小程序时填写，格式如{ "appid": "pagepath": { "value": any } }
        /// </summary>
        [JsonProperty("miniprogram")]
        public NewTmplMiniProgramInfo MiniProgram { get; set; }

        /// <summary>
        /// 模板内容，格式形如 { "key1": { "value": any }, "key2": { "value": any } }
        /// </summary>
        [JsonProperty("data")]
        public Dictionary<string, NewTmplDataItem> Data { get; set; }
    }

    /// <summary>
    /// 跳转小程序信息
    /// </summary>
    public class NewTmplMiniProgramInfo
    {
        /// <summary>
        /// 小程序appId
        /// </summary>
        [JsonProperty("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 页面路径
        /// </summary>
        [JsonProperty("pagepath")]
        public string PagePath { get; set; }
    }

    /// <summary>
    /// 模板内容
    /// </summary>
    public class NewTmplDataItem
    {
        /// <summary>
        /// 模板内容
        /// </summary>
        /// <param name="value"></param>
        public NewTmplDataItem(string value)
        {
            Value = value;
        }

        /// <summary>
        /// 项目值
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}