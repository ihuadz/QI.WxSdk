using WebApiClientCore;
using QI.Wx.Sdk.MiniProgram.Dtos;

namespace QI.Wx.Sdk.MiniProgram.Apis.QRCode;

/// <summary>
/// QRCode的拦截，
/// </summary>
public class QRCodeApiFilter : AccessTokenApiFilter
{
    /// <summary>
    /// 响应处理，成功时返回byte[]，失败返回错误json
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public override async Task OnResponseAsync(ApiResponseContext context)
    {
        var repose = context.HttpContext.ResponseMessage;
        if(repose.IsSuccessStatusCode)
        {
            if(repose.Content.Headers.ContentType.MediaType == "application/json")
            {
                var str = await repose.Content.ReadAsStringAsync();
                context.Result = JsonConvert.DeserializeObject<GetWxaCodeResult>(str);
            }
            else
            {
                var ret = new GetWxaCodeResult()
                {
                    ErrorCode = 0,
                    RawBytes = await repose.Content.ReadAsByteArrayAsync()
                };
                context.Result = ret;
            }
        }
        else 
        {
            //return Task.CompletedTask;
            //throw new WxException("StatusCode:" + repose.StatusCode.ToString());
        }

        //return Task.CompletedTask;
    }
}
