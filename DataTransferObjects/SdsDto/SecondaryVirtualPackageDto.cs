using System;

namespace WasWebServerCore.DataTransferObjects.SdsDto
{
    /// <summary>
    /// BarcodeInfoDto.
    /// </summary>
    public class SecondaryVirtualPackageDto
    {
        /// <summary>
        /// Gets or sets the identifier.
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
        /// 格口号.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string ShuteId { get; set; }

        /// <summary>
        /// 箱号.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string PackageNo { get; set; }

        /// <summary>
        /// 封包号.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string WaitPackageNo { get; set; }

        /// <summary>
        /// 数量.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int PackageNumber { get; set; }

        /// <summary>
        /// 状态.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Status { get; set; }


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
