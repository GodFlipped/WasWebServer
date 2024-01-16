using System;

namespace WasWebServerCore.DataTransferObjects.SdsDto
{
    /// <summary>
    /// BarcodeInfoDto.
    /// </summary>
    public class RoutingInfoDto
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
        /// 分拣计划.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string SorterPlan { get; set; }

        /// <summary>
        /// 物理地址.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string PhycialShute { get; set; }

        /// <summary>
        /// 逻辑地址.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string LogicalDestination { get; set; }


        /// <summary>
        /// 分拣模式.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int RoutingStrategy { get; set; }


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
