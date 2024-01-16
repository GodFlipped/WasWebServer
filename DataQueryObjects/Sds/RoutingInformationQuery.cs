using System;

namespace WasWebServerCore.DataQueryObjects.Sds
{
    /// <summary>
    /// LocationTypeQuery.
    /// </summary>
    public class RoutingInformationQuery : SortQuery
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

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
        /// 父级.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string ParentId { get; set; }
        /// <summary>
        /// 创建者
        /// </summary>
        /// /// <summary>
        public string CreateBy { get; set; }
        /// <summary>
        /// 创建时间开始
        /// </summary>
        public DateTime? CreateTimeStart { get; set; }
        /// <summary>
        /// 创建时间结束
        /// </summary>
        public DateTime? CreateTimeEnd { get; set; }
        /// <summary>
        /// 更新者
        /// </summary>
        public string UpdateBy { get; set; }
        /// <summary>
        /// 更新时间开始
        /// </summary>
        public DateTime? UpdateTimeStart { get; set; }
        /// <summary>
        /// 更新时间结束
        /// </summary>
        public DateTime? UpdateTimeEnd { get; set; }
    }
}