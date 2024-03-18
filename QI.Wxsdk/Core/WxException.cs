namespace QI.Wx.Sdk.Core
{
    /// <summary>
    /// WxException
    /// </summary>
    [Serializable]
    public class WxException : Exception
    {
        /// <summary>
        /// WxException
        /// </summary>
        public WxException()
        {
        }

        /// <summary>
        /// WxException
        /// </summary>
        /// <param name="message"></param>
        public WxException(string message) : base(message)
        {
        }

        /// <summary>
        /// WxException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public WxException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}