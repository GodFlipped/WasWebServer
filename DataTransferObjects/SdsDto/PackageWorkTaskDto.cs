using System;
using WasWebServer.Enums;

namespace WasWebServerCore.DataTransferObjects.SdsDto
{
    /// <summary>
    /// SubWorkTaskDto.
    /// </summary>
    public class PackageWorkTaskDto
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
        /// 条码.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string ObjectToHandle { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string PackageNumber { get; set; }

        /// <summary>
        /// 格口号.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string ShuteId { get; set; }


        /// <summary>
        /// 箱号代码.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string RfidCode { get; set; }

        /// <summary>
        /// 类型.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Router { get; set; }


        /// <summary>
        /// 箱号代码.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string ReceiveSiteCode { get; set; }

        /// <summary>
        /// 运输类型.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string CategoryText { get; set; }

        /// <summary>
        /// 路线.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string RouterNum { get; set; }


        /// <summary>
        /// 打印机.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Executor { get; set; }


        /// <summary>
        /// 状态.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public WorkTaskStatus Status { get; set; }

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
