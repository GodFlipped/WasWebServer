using System;
using WasWebServer.Enums;

namespace WasWebServerCore.DataTransferObjects.SdsDto
{
    /// <summary>
    /// SubWorkTaskDto.
    /// </summary>
    public class MessageWorkTaskDto
    {
        /// <summary>
        /// ID
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// 名称.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// 条码.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string ObjectToHandle { get; set; }

        /// <summary>
        /// 唯一代码.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string TrackingId { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public SorterMessageType Type { get; set; }

        /// <summary>
        /// 导入台.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Induct { get; set; }

        /// <summary>
        /// .导入结果
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string InductMode { get; set; }

        /// <summary>
        /// 导入时间
        /// </summary>
        public DateTime? InductTime { get; set; }

        /// <summary>
        /// 重量.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public decimal Weight { get; set; }

        /// <summary>
        /// 执行者.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Executor { get; set; }


        /// <summary>
        /// 状态.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public WorkTaskStatus Status { get; set; }

        /// <summary>
        ///触发方式.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public WorkTaskTriggerMode TriggerMode { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string CreateBy { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public string UpdateBy { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? UpdateTime { get; set; }


    }
}
