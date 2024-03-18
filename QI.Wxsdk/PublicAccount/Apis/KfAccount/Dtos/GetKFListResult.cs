using System.Collections.Generic;

namespace QI.Wx.Sdk.PublicAccount.Apis.KfAccount.Dtos
{
    /// <summary>
    /// 获取客服基本信息返回结果
    /// </summary>
    public class GetKFListResult
    {
        /// <summary>
        /// 客服列表
        /// </summary>
        public List<KFDataItem> KFList { get; set; }

    }
}