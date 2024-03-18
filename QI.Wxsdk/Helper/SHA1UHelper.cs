using System;
using System.Security.Cryptography;
using System.Text;

namespace QI.Wx.Sdk.Helper
{
    /// <summary>
    /// SHA-1 算法工具类。
    /// </summary>
    public static class SHA1UHelper
    {
        /// <summary>
        /// 获取 SHA-1 信息摘要。
        /// </summary>
        /// <param name="bytes">信息字节数组。</param>
        /// <returns>信息摘要字节数组。</returns>
        public static byte[] Hash(byte[] bytes)
        {
            if (bytes == null) throw new ArgumentNullException(nameof(bytes));

            using SHA1 sha = SHA1.Create();
            return sha.ComputeHash(bytes);
        }

        /// <summary>
        /// 获取 SHA-1 信息摘要。
        /// </summary>
        /// <param name="message">文本信息。</param>
        /// <returns>信息摘要。</returns>
        public static string Hash(string message)
        {
            if (message == null) throw new ArgumentNullException(nameof(message));

            byte[] msgBytes = Encoding.UTF8.GetBytes(message);
            byte[] hashBytes = Hash(msgBytes);
            //return BitConverter.ToString(hashBytes).Replace("-", "");
            var enText = new StringBuilder();
            foreach (var b in hashBytes)
                enText.AppendFormat("{0:x2}", b);

            return enText.ToString();
        }
    }
}
