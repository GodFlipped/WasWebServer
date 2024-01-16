using System;

namespace WasWebServerCore.DataTransferObjects.SdsDto
{
    /// <summary>
    /// SystemSequenceDto.
    /// </summary>
    public partial class SystemSequenceDto
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
        /// 前缀
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Prefix { get; set; }

        /// <summary>
        /// 值.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Value { get; set; }


        /// <summary>
        /// 最大值.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string MaxValue { get; set; }



        /// <summary>
        /// 最小值.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string MinValue { get; set; }

        /// <summary>
        /// 增加值.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string IncreaseRate { get; set; }

        /// <summary>
        /// 是否激活.
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
