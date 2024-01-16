using System;

namespace WasWebServerCore.DataTransferObjects.SdsDto
{
    /// <summary>
    /// BarcodeInfoDto.
    /// </summary>
    public class ShuteDto
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }
       
        /// <summary>
        /// 设备编号.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string DeviceName1 { get; set; }

        /// <summary>
        /// 格口包裹号.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string PackageNo { get; set; }

        /// <summary>
        /// 上一个格口包裹号.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string TheLastPackageNo { get; set; }

        /// <summary>
        /// 取消建包号.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string SpecialPackageNo { get; set; }

        /// <summary>
        /// 格口数量.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int PackageNumber { get; set; }


        /// <summary>
        /// 预建包数量.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int PrePackageNumber { get; set; }

        /// <summary>
        /// 打印机.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string PrintId { get; set; }


        /// <summary>
        /// 物理分拣机.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string RfidCode { get; set; }


   
        /// <summary>
        /// 是否挡板拉开.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public bool IsFull { get; set; }


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
