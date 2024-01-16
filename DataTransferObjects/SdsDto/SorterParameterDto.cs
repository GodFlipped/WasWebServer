using System;

namespace WasWebServerCore.DataTransferObjects.SdsDto
{
    /// <summary>
    /// SorterParameterDto.
    /// </summary>
    public partial class SorterParameterDto
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
        /// 连接名称
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string ConnectionName { get; set; }

        /// <summary>
        /// DB地址.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string StorageDb { get; set; }

        /// <summary>
        /// 起始地址.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string StartAddress { get; set; }

        /// <summary>
        /// 值类型
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string ValueType { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Value { get; set; }

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
