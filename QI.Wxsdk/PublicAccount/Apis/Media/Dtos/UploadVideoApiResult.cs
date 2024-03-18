using QI.Wx.Sdk.Core;
using QI.Wx.Sdk.PublicAccount;

namespace QI.Wx.Sdk.PublicAccount.Apis.Media
{
    public class UploadVideoApiResult : ApiResultBase
    {
        public string type { get; set; }
        public string media_id { get; set; }
        public int created_at { get; set; }
    }
}