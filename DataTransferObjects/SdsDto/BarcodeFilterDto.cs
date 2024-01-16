using System;

namespace WasWebServerCore.DataTransferObjects.SdsDto
{
    /// <summary>
    /// BarcodeFilterDto.
    /// </summary>
    public partial class BarcodeFilterDto
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
        /// 是否激活
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
