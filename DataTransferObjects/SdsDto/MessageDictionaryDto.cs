using System;

namespace WasWebServerCore.DataTransferObjects.SdsDto
{
    /// <summary>
    /// MessageDictionaryDto.
    /// </summary>
    public partial class MessageDictionaryDto
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
        /// 值
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Value { get; set; }

        /// <summary>
        /// 消息Id.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string MessageId { get; set; }

        /// <summary>
        /// 是否发送.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public bool IsSend { get; set; }

        /// <summary>
        /// 操作者.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string OperatorName { get; set; }

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
