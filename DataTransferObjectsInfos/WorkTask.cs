using System;

namespace WasWebServerCore.DataTransferObjectsInfos
{
    public class WorkTask
    {
        public string OperatorName { get; set; }
        /// <summary>
        /// 托盘号
        /// </summary>
        public string ObjectToHandle { get; set; }
        public string TaskType { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public OperatedInfo Create { get; set; }
        public OperatedInfo Ready { get; set; }
        public DateTime? CreateOperatedTime { get; set; }
        public DateTime? ReleaseOperatedTime { get; set; }
        public DateTime? CancelledOperatedTime { get; set; }
        public DateTime? CompletedOperatedTime { get; set; }
        /// <summary>
        /// 释放时间
        /// </summary>
        public OperatedInfo Release { get; set; }
        public OperatedInfo Booking { get; set; }
        public OperatedInfo Active { get; set; }
        public OperatedInfo Running { get; set; }
        /// <summary>
        /// 取消时间
        /// </summary>
        public OperatedInfo Cancelled { get; set; }
        /// <summary>
        /// 终止时间
        /// </summary>
        public OperatedInfo Terminated { get; set; }
        public OperatedInfo Suspended { get; set; }
        public OperatedInfo Resume { get; set; }
        public OperatedInfo Done { get; set; }
        /// <summary>
        /// 完成时间
        /// </summary>
        public OperatedInfo Completed { get; set; }
        public OperatedInfo Faulted { get; set; }
        public OperatedInfo Timeout { get; set; }
        public string Results { get; set; }
        public string ResultCode { get; set; }
        public string Reason { get; set; }

        public string TaskCode { get; set; } 
    }
}