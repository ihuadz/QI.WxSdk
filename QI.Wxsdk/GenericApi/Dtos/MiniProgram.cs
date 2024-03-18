using Newtonsoft.Json;

namespace QI.Wx.Sdk.GenericApi.Dtos
{
    /// <summary>
    /// 小程序信息
    /// </summary>
    public class MiniProgram
    {
        /// <summary>
        /// 小程序 AppId。
        /// </summary>
        [JsonProperty("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 小程序页面路径。
        /// </summary>
        [JsonProperty("pagepath")]
        public string PagePath { get; set; } = string.Empty;
    }
}
