namespace QI.Wx.Sdk.Core
{
    /// <summary>
    /// API请求结果基类
    /// </summary>
    public class ApiResultBase
    {
        /// <summary>
        /// 返回码
        /// </summary>
        [JsonProperty("errcode")]
        public virtual int ErrorCode { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        [JsonProperty("errmsg")]
        public virtual string ErrMessage { get; set; } = string.Empty;

        /// <summary>
        /// 错误码 + 错误消息
        /// </summary>
        [JsonProperty]
        public virtual string Message => IsSuccess? "" : $"errcode:{ErrorCode}, errmsg:{ErrMessage}";

        /// <summary>
        /// 是否为成功返回
        /// </summary>
        /// <returns></returns>
        [JsonProperty]
        public virtual bool IsSuccess => ErrorCode == 0;

        /// <summary>
        /// AccessToken无效
        /// </summary>
        [JsonIgnore]
        public virtual bool IsAccessTokenInvalid => ErrorCode == 40001;

    }
}