using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QI.Wx.Sdk.GenericApi.Dtos
{
    /// <summary>
    /// 下发小程序和公众号统一的服务消息,Post内容
    /// </summary>
    public class UniformMessageInput
    {
        /// <summary>
        /// 用户openid
        /// 可以是小程序的openid，也可以是mp_template_msg.appid对应的公众号的openid
        /// </summary>
        [JsonProperty("touser")]
        public string ToUserOpenId { get; set; } = string.Empty;

        /// <summary>
        /// 公众号模板消息相关的信息,
        /// 可以参考公众号模板消息接口
        /// </summary>
        [JsonProperty("mp_template_msg")]
        public MpTemplateMessage? MpTemplateMessage { get; set; }

    }

    /// <summary>
    /// 公众号模板消息相关的信息
    /// </summary>
    public class MpTemplateMessage
    {
        /// <summary>
        /// 公众号appid，要求与小程序有绑定且同主体
        /// </summary>
        [JsonProperty("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 公众号模板id
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; } = string.Empty;

        /// <summary>
        /// 公众号模板消息所要跳转的url
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 公众号模板消息所要跳转的小程序，小程序的必须与公众号具有绑定关系
        /// </summary>
        [JsonProperty("miniprogram")]
        public MiniProgram MiniProgram { get; set; }

        /// <summary>
        /// 公众号模板消息的数据
        /// </summary>
        [JsonProperty("data")]
        public IDictionary<string, DataItem>? Data { get; set; }

        /// <summary>
        /// 数据项
        /// </summary>
        public class DataItem
        {
            /// <summary>
            /// 获取或设置消息内容文本。
            /// </summary>
            [Newtonsoft.Json.JsonProperty("value")]
            public string Value { get; set; } = string.Empty;

            /// <summary>
            /// 获取或设置消息字体颜色（格式：#RRGGBB）。
            /// </summary>
            [Newtonsoft.Json.JsonProperty("color")]
            public string Color { get; set; } = string.Empty;
        }
    }
}
