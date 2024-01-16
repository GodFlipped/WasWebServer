using System;

namespace WasWebServerCore.DataTransferObjects.SdsDto
{
    /// <summary>
    /// BarcodeInfoDto.
    /// </summary>
    public class SorterPlanDto
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
        /// 是否启用.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public bool IsEnable { get; set; }
        /// <summary>
        /// 是否激活.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public bool IsActive { get; set; }
        /// <summary>
        /// 中转场.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string SiteNo { get; set; }

        /// <summary>
        /// 分拣模式.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string SorterMode { get; set; }

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
