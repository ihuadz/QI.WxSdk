using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QI.Wx.Sdk.MiniProgram.Apis.AuthUser.Dtos
{
    /// <summary>
    /// 请求手机号输入
    /// </summary>
    public class GetUserPhonenumberInput
    {
        /// <summary>
        /// 
        /// </summary>
        public GetUserPhonenumberInput() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        public GetUserPhonenumberInput(string code)
        {
            this.code = code;
        }

        /// <summary>
        /// 请求手机号凭证
        /// </summary>
        public string code { get; set; }
    }
}
