using System;

namespace WasWebServerCore.DataTransferObjects.SdsDto
{
    /// <summary>
    /// PhycialSorterDto.
    /// </summary>
    public partial class PhycialSorterDto
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
        /// 代码.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Code { get; set; }

        /// <summary>
        /// 描述.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Description { get; set; }

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
