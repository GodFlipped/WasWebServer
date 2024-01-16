using System;

namespace WasWebServerCore.DataQueryObjects.Sds
{
    /// <summary>
    /// LogicalDestinationQuery.
    /// </summary>
    public class LogicalDestinationQuery : SortQuery
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///父级.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string ParendId { get; set; }

        /// <summary>
        /// 显示名称.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string DisplayName { get; set; }

        /// <summary>
        /// 分拣计划.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string SorterPlan { get; set; }

        /// <summary>
        /// 是否激活.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public bool IsActive { get; set; }

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