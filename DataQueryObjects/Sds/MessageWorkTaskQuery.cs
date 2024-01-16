using System;
using WasWebServer.Enums;

namespace WasWebServerCore.DataQueryObjects.Sds
{
    /// <summary>
    /// LocationTypeQuery.
    /// </summary>
    public class MessageWorkTaskQuery
    {

        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 条码
        /// </summary>
        public string ObjectToHandle { get; set; }

        /// <summary>
        /// 条码
        /// </summary>
        public string TrackingId { get; set; }

        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        /// <value>
        /// 状态.
        /// </value>
        public WorkTaskStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        /// <value>
        /// 类型.
        /// </value>
        public SorterMessageType? Type { get; set; }


        /// <summary>
        /// 创建时间开始
        /// </summary>
        public DateTime? CreateTimeStart { get; set; }
        /// <summary>
        /// 创建时间结束
        /// </summary>
        public DateTime? CreateTimeEnd { get; set; }

    }
}