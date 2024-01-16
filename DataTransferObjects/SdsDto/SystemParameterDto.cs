using System;

namespace WasWebServerCore.DataTransferObjects.SdsDto
{
    /// <summary>
    /// SystemParameterDto.
    /// </summary>
    public partial class SystemParameterDto
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
        /// 值
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Value { get; set; }

        /// <summary>
        /// 模板.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Template { get; set; }


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
