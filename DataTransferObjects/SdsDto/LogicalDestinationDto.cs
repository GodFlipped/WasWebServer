using System;

namespace WasWebServerCore.DataTransferObjects.SdsDto
{
    /// <summary>
    /// LogicalDestinationDto.
    /// </summary>
    public partial class LogicalDestinationDto
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
        /// 父级
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string ParentId { get; set; }

        /// <summary>
        /// 显示名称.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string DisplayName { get; set; }

        /// <summary>
        /// 是否可用.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Mot { get; set; }

        /// <summary>
        /// 是否激活
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Client { get; set; }

        /// <summary>
        ///分拣计划.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string SorterPlan { get; set; }

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
