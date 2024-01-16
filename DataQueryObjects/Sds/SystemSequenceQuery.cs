using System;

namespace WasWebServerCore.DataQueryObjects.Sds
{
    /// <summary>
    /// SystemSequenceQuery.
    /// </summary>
    public class SystemSequenceQuery : SortQuery
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
        /// 前缀.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Prefix { get; set; }

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