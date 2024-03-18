using QI.Wx.Sdk.MiniProgram.Apis.QRCode.Dtos;

namespace QI.Wx.Sdk.MiniProgram.Dtos
{
    /// <summary>
    /// <para>表示 [POST] /wxa/getwxacodeunlimit 接口的请求。</para>
    /// </summary>
    public class GetWxaCodeUnlimitedInput
    {
        /// <summary>
        /// 获取或设置扫码场景值,最大32个可见字符，只支持数字，大小写英文以及部分特殊字符
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; } = string.Empty;

        /// <summary>
        /// 页面 page，例如 pages/index/index，根路径前不要填加 /，
        /// 不能携带参数（参数请放在 scene 字段里），如果不填写这个字段，默认跳主页面
        /// </summary>
        [JsonProperty("page")]
        public string Page { get; set; }

        /// <summary>
        /// 检查 page 是否存在，
        /// 为 true 时 page 必须是已经发布的小程序存在的页面（否则报错）；
        /// 为 false 时允许小程序未发布或者 page 不存在， 但 page 有数量上限（60000个）请勿滥用
        /// </summary>
        [JsonProperty("check_path")]
        public bool CheckPath { get; set; } = true;

        /// <summary>
        /// 要打开的小程序版本。
        /// 正式版为 release，体验版为 trial，开发版为 develop
        /// </summary>
        [JsonProperty("env_version")]
        public string EnvVersion { get; set; } = ConstWx.MP_Env_Ver_Release;

        /// <summary>
        /// 二维码的宽度，单位 px，最小 280px，最大 1280px
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
