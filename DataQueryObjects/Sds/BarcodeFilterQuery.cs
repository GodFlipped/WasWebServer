using System;

namespace WasWebServerCore.DataQueryObjects.Sds
{
    /// <summary>
    /// BarcodeFilterQuery.
    /// </summary>
    public class BarcodeFilterQuery : SortQuery
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
        /// 值.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Value { get; set; }

        /// <summary>
        /// 正则.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string RegularValue { get; set; }

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