﻿using QI.Wx.Sdk.PublicAccount.Apis.Menu.Dtos;
using System.Threading.Tasks;
using WebApiClientCore.Attributes;
using QI.Wx.Sdk.Core;
using QI.Wx.Sdk.PublicAccount.Apis.Menu;

namespace QI.Wx.Sdk.PublicAccount.Apis
{
    /// <summary>
    /// 公众号自定义菜单接口
    /// </summary>
    [HttpHost("https://api.weixin.qq.com/cgi-bin/menu/")]
    public interface IWxPaMenuApi : IWxApiWithAccessTokenFilter
    {
        /// <summary>
        /// 查询自定义菜单的结构。另外请注意，在设置了个性化菜单后，使用本自定义菜单查询接口可以获取默认菜单和全部个性化菜单信息。
        /// </summary>
        /// <returns></returns>
        [HttpGet("get")]
        Task<GetMenuApiResult> GetAsync();

        /// <summary>
        ///
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("create")]
        Task<ApiResultBase> CreateAsync([JsonNetContent(CharSet = "utf-8")] CreateMenuInput input);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        [HttpGet("delete")]
        Task<ApiResultBase> DeleteAsync();

        /// <summary>
        /// 创建个性化菜单
        /// </summary>
        /// <returns></returns>
        [HttpPost("addconditional")]
        Task<AddConditionalApiResult> AddConditionalAsync([JsonNetContent(CharSet = "utf-8")] AddConditionalInput input);

        /// <summary>
        /// 删除个性化菜单
        /// </summary>
        /// <returns></returns>
        [HttpPost("delconditional")]
        Task<ApiResultBase> DelConditionalAsync([JsonNetContent(CharSet = "utf-8")] DelConditionalInput input);

        /// <summary>
        /// 测试个性化菜单匹配结果
        /// </summary>
        /// <returns></returns>
        [HttpPost("trymatch")]
        Task<TryMatchApiResult> TryMatchAsync([JsonNetContent(CharSet = "utf-8")] TryMatchInput input);
    }
}