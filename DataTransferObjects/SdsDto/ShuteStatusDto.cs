using System;

namespace WasWebServerCore.DataTransferObjects.SdsDto
{
    /// <summary>
    /// ShuteStatusDto.
    /// </summary>
    public class ShuteStatusDto
    {
        /// <summary>
        /// Gets or sets the identifier.
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
        /// 设备编号.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string DisplayName { get; set; }


        /// <summary>
        /// 发车时间.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string CutoffTimings { get; set; }

        /// <summary>
        /// 物理分拣机.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string LogicalSorter { get; set; }


        /// <summary>
        /// 是否建包.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public bool IsActive { get; set; }


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
