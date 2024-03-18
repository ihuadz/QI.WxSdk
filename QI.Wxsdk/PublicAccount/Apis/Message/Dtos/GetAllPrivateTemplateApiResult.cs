using System.Collections.Generic;
using QI.Wx.Sdk.Core;
using QI.Wx.Sdk.PublicAccount;

namespace QI.Wx.Sdk.PublicAccount.Apis.Message
{
    public class GetAllPrivateTemplateApiResult : ApiResultBase
    {


        /// <summary>
        /// 模板列表
        /// </summary>
        public List<TemplateInfo> TemplateList { get; set; }

    }
}