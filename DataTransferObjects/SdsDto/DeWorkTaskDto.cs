using System;
using WasWebServer.Enums;

namespace WasWebServerCore.DataTransferObjects.SdsDto
{
    /// <summary>
    /// SourceWorkTaskDto.
    /// </summary>
    public class DeWorkTaskDto
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
        /// 唯一ID.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string TrackingId { get; set; }

        /// <summary>
        /// 当前地址.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string CurrentShuteAddr { get; set; }

        /// <summary>
        /// 包裹号.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string ActivePackageNo { get; set; }


        /// <summary>
        /// 循环圈数.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int CycleTimes { get; set; }

        /// <summary>
        /// 分拣机代码.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string SortResultSorter { get; set; }

        /// <summary>
        /// 状态.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public WorkTaskStatus Status { get; set; }


        /// <summary>
        /// 结果
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Results { get; set; }

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

        /// <summary>
        /// 挂起时间
        /// </summary>
        public DateTime? SuspendedTime { get; set; }

        /// <summary>
        /// 激活时间
        /// </summary>
        public DateTime? ActiveTime { get; set; }


    }
}
