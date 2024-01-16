using System;

namespace WasWebServerCore.DataTransferObjects.SdsDto
{
    /// <summary>
    /// WasExecutorDto.
    /// </summary>
    public partial class WasExecutorDto
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
        /// 执行者
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string ExecuteOperator { get; set; }

        /// <summary>
        /// 连接.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Connection { get; set; }


        /// <summary>
        /// 当前状态.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string CurrentAddress { get; set; }

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
