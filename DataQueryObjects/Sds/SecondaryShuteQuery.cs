using System;

namespace WasWebServerCore.DataQueryObjects.Sds
{
    /// <summary>
    /// LocationTypeQuery.
    /// </summary>
    public class SecondaryShuteQuery : SortQuery
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

        /// <summary>
        /// 格口包裹号.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string PackageNo { get; set; }

        /// <summary>
        /// 物理分拣机.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string PickingWall { get; set; }
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