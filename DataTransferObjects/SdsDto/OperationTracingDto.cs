using System;

namespace WasWebServerCore.DataTransferObjects.SdsDto
{
    /// <summary>
    /// OperationTracingsDto.
    /// </summary>
    public partial class OperationTracingDto
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
        /// 用户
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string User { get; set; }

        /// <summary>
        /// 源.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Source { get; set; }


        /// <summary>
        /// 操作.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Operation { get; set; }

        /// <summary>
        /// 对象.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Object { get; set; }

        /// <summary>
        /// 对象值.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string ObjectValue { get; set; }

        /// <summary>
        /// 结果.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Result { get; set; }

        /// <summary>
        /// 内容.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Context { get; set; }

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
