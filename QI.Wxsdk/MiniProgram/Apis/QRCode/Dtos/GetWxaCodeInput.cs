using QI.Wx.Sdk.MiniProgram.Apis.QRCode.Dtos;

namespace QI.Wx.Sdk.MiniProgram.Dtos
{
    /// <summary>
    /// <para>表示 [POST] /wxa/getwxacode 接口的请求。</para>
    /// </summary>
    public class GetWxaCodeInput
    {
        /// <summary>
        /// 扫码进入的小程序页面路径，最大长度 128 字节，不能为空
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }

        /// <summary>
        /// 要打开的小程序版本。正式版为 release，体验版为 trial，开发版为 develop
        /// </summary>
        [JsonProperty("env_version")]
        public string EnvVersion { get; set; } = ConstWx.MP_Env_Ver_Release;


        /// <summary>
        /// 二维码的宽度，单位 px。最小 280px，最大 1280px
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; } = 430;

        /// <summary>
        /// 自动配置线条颜色，如果颜色依然是黑色
        /// </summary>
        [JsonProperty("auto_color")]
        public bool IsAutoColor { get; set; } = false;

        /// <summary>
        /// auto_color 为 false 时生效，使用 rgb 设置颜色 例如 {"r":"xxx","g":"xxx","b":"xxx"} 十进制表示
        /// </summary>
        [JsonProperty("line_color")]
        public QRCodeColor LineColor { get; set; }

        /// <summary>
        /// 是否需要透明底色，为 true 时，生成透明底色的小程序码
        /// </summary>
        [JsonProperty("is_hyaline")]
        public bool IsHyaline { get; set; } = false;
    }
}
