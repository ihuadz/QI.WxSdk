namespace QI.Wx.Sdk.MiniProgram.Dtos;

/// <summary>
/// 获取小程序 URL Link 请求数据
/// </summary>
public class GenerateUrlLinkInput
{
    /// <summary>
    /// 通过 URL Link 进入的小程序页面路径，
    /// 必须是已经发布的小程序存在的页面，不可携带 query 。path 为空时会跳转小程序主页
    /// </summary>
    [JsonProperty("path")]
    public string Path { get; set; } = string.Empty;

    /// <summary>
    /// 通过 URL Link 进入小程序时的query，
    /// 最大1024个字符，只支持数字，大小写英文以及部分特殊字符：!#$&'()*+,/:;=?@-._~%
    /// </summary>
    [JsonProperty("query")]
    public string Query { get; set; } = string.Empty;

    /// <summary>
    /// 要打开的小程序版本。
    /// 正式版为 "release"，体验版为"trial"，开发版为"develop"，仅在微信外打开时生效。
    /// </summary>
    [JsonProperty("env_version")]
    public string EnvironmentVersion { get; set; } = string.Empty;

    /// <summary>
    /// 小程序 URL Link 失效类型，
    /// 失效时间：0，失效间隔天数：1
    /// </summary>
    [JsonProperty("expire_type")]
    public int ExpireType { get; set; } = 1;

    /// <summary>
    /// 到期失效的 URL Link 的失效时间，为 Unix 时间戳。
    /// 生成的到期失效 URL Link 在该时间前有效。最长有效期为30天。expire_type 为 0 必填
    /// </summary>
    [JsonProperty("expire_time")]
    public long ExpireTimestamp { get; set; } = 0;

    /// <summary>
    /// 到期失效的URL Link的失效间隔天数。
    /// 生成的到期失效URL Link在该间隔时间到达前有效。最长间隔天数为30天。expire_type 为 1 必填
    /// </summary>
    [JsonProperty("expire_interval")]
    public int ExpireInterval { get; set; } = 30;

    /// <summary>
    /// 云开发静态网站自定义 H5 配置参数
    /// </summary>
    [JsonProperty("cloud_base")]
    public CloudBase CloudBase { get; set; }
}

/// <summary>
/// 云开发静态网站自定义 H5 配置参数，可配置中转的云开发 H5 页面。不填默认用官方 H5 页面
/// </summary>
public class CloudBase
{
    /// <summary>
    /// 获取或设置云开发环境 ID。
    /// </summary>
    [JsonProperty("env")]
    public string EnvironmentId { get; set; } = string.Empty;

    /// <summary>
    /// 获取或设置静态网站自定义域名。
    /// </summary>
    [JsonProperty("domain")]
    public string Domain { get; set; } = string.Empty;

    /// <summary>
    /// 获取或设置云开发静态网站 H5 页面路径。
    /// </summary>
    [JsonProperty("path")]
    public string Path { get; set; } = string.Empty;

    /// <summary>
    /// 获取或设置云开发静态网站 H5 页面参数。
    /// </summary>
    [JsonProperty("query")]
    public string Query { get; set; } = string.Empty;

    /// <summary>
    /// 获取或设置第三方平台的 AppId。
    /// </summary>
    [JsonProperty("resource_appid")]
    public string ResourceAppId { get; set; } = string.Empty;
}
