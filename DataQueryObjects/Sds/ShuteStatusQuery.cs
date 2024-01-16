using System;

namespace WasWebServerCore.DataQueryObjects.Sds
{
    /// <summary>
    /// ShuteStatusQuery.
    /// </summary>
    public class ShuteStatusQuery : SortQuery
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// 设备编号.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string DeviceName1 { get; set; }

        /// 是否建包.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public bool IsActive { get; set; }

        /// <summary>
        /// 物理分拣机.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string LogicalSorter { get; set; }
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