using System.ComponentModel.DataAnnotations;

namespace QI.Wx.Sdk.PublicAccount.Apis.AuthUser.Dtos
{
    /// <summary>
    /// 性别类型
    /// </summary>
    public enum WeChatSexTypes
    {
        /// <summary>
        /// 未知
        /// </summary>
        [Display(Name = "未知")] UnKnown = 0,

        /// <summary>
        /// 男人
        /// </summary>
        [Display(Name = "男")] Man = 1,

        /// <summary>
        /// 女人
        /// </summary>
        [Display(Name = "女")] Woman = 2
    }
}