namespace WasWebServerCore.WasDto
{
    public class SaleOutboundOrderLine
    {
        /// <summary>
        /// 出货计划行ID
        /// </summary>
        public string DeliverPlanLineID { get; set; }
        /// <summary>
        /// 交付计划行ID
        /// </summary>
        public string PlanDocLineID { get; set; }
        /// <summary>
        /// 料品编码
        /// </summary>
        public string ItemMasterCode { get; set; }
        /// <summary>
        /// 特殊工艺号
        /// </summary>
        public string SpeTech_No { get; set; }
        /// <summary>
        /// 出货数量
        /// </summary>
        public decimal ShipQty { get; set; }
        /// <summary>
        /// 出库类型
        /// </summary>
        public int ShipType { get; set; }
        /// <summary>
        /// 客户编码
        /// </summary>
        public string CustomerCode { get; set; }
        /// <summary>
        /// 客户地址编码
        /// </summary>
        public string CustomerSiteCode { get; set; }
        /// <summary>
        /// 最终价
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }
        /// <summary>
        /// 客户名称
        /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        /// 送货地址
        /// </summary>
        public string CustomerSite { get; set; }

        public string OutOrder { get; set; }
        public string SOID { get; set; }
        public string isbulk { get; set; }
        public string CustContractNo { get; set; }
        public string storage { get; set; }
    }
}
