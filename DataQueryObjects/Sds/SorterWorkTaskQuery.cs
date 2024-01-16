using System;
using WasWebServer.Enums;

namespace WasWebServerCore.DataQueryObjects.Sds
{
    /// <summary>
    /// LocationTypeQuery.
    /// </summary>
    public class SorterWorkTaskQuery
    {

        /// <summary>
        /// Gets or sets the ExecuteWorkTask.
        /// </summary>
        /// <value>
        /// 唯一ID.
        /// </value>
        public string TrackingId { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 条码
        /// </summary>
        public string ObjectToHandle { get; set; }

        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        /// <value>
        /// 状态.
        /// </value>
        public WorkTaskStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets the SourceStatus.
        /// </summary>
        /// <value>
        /// 源状态.
        /// </value>
        public WorkTaskStatus? SourceStatus { get; set; }

        /// <summary>
        /// 创建时间开始
        /// </summary>
        public DateTime? CreateTimeStart { get; set; }
        /// <summary>
        /// 创建时间结束
        /// </summary>
        public DateTime? CreateTimeEnd { get; set; }

        /// <summary>
        /// Gets or sets the Comments.
        /// </summary>
        /// <value>
        /// 备注.
        /// </value>
        public string ActivePackageNo { get; set; }


        //补码id
        public string ExecuteWorkTaskId { get; set; }
    }
}