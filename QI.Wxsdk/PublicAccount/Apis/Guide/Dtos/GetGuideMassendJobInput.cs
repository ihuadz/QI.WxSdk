using Newtonsoft.Json;

namespace QI.Wx.Sdk.PublicAccount.Apis.Guide.Dtos
{
    public class GetGuideMassendJobInput
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("task_id")]
        public int TaskId { get; set; }
    }
}