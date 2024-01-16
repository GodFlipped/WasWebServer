using System;

namespace WasWebServerCore.DataQueryObjects.Sds
{
    /// <summary>
    /// LocationTypeQuery.
    /// </summary>
    public class SortingPackageQuery : SortQuery
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// 格口号.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string ShuteId { get; set; }

        /// <summary>
        /// 包裹号.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string PackageNo { get; set; }

        /// <summary>
        /// 封包号.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string WaitPackageNo { get; set; }

        /// <summary>
        /// 状态.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Status { get; set; }
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