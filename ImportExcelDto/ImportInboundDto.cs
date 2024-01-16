using System;

namespace WasWebServerCore.ImportExcelDto
{
    public class ImportInboundDto
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }
        /// <summary>
        /// 订单号.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string OrderNo { get; set; }
        /// <summary>
        /// 订单类型.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int OrderType { get; set; }  //类型从string改成了int
        /// <summary>
        /// 料号.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Sku { get; set; }
        /// <summary>
        /// 料号名称.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string SkuName { get; set; }
        /// <summary>
        /// 计划数量.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public decimal PlanQuality { get; set; }
        /// <summary>
        /// 已扫描数量.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public decimal ScannedQuality { get; set; }
        /// <summary>
        /// 未入库数量.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public decimal NoInbundQuality { get; set; }
        /// <summary>
        /// 入库数量.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public decimal InbundQuality { get; set; }
        /// <summary>
        /// 紧急入库数量.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public decimal EmergencyInbundQuality { get; set; }
        /// <summary>
        /// 产线编码.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Department { get; set; }
        /// <summary>
        /// 产线名称.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string DepartmentName { get; set; }
        /// <summary>
        /// PO.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string PO { get; set; }
        /// <summary>
        /// 条码是否生成.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public bool IsGeneratedCode { get; set; }
        /// <summary>
        /// 计划开工时间.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public DateTime PlanStartDate { get; set; }
        /// <summary>
        /// 实际开工时间.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public DateTime ActualStartDate { get; set; }
        /// <summary>
        /// 是否散装.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public bool IsBulk { get; set; }
        /// <summary>
        /// 状态.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Status { get; set; } //从string改为int
    }
}
