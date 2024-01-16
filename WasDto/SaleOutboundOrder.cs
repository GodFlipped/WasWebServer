using System;
using System.Collections.Generic;

namespace WasWebServerCore.WasDto
{
    public class BILL
    {
        /// <summary>
        /// 出货计划单ID
        /// </summary>
        public string ShipPlanID { get; set; }
        /// <summary>
        /// 出货计划单号
        /// </summary>
        public string ShipPlanDocNo { get; set; }
        /// <summary>
        /// 出货计划日期
        /// </summary>
        public DateTime ShipPlanDate { get; set; }
        /// <summary>
        /// 出货计划号
        /// </summary>
        public string ShipPlanNO { get; set; }
        /// <summary>
        /// 出货组织编码
        /// </summary>
        public string OrgCode { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public bool ShipPlanStatus { get; set; }
        /// <summary>
        /// 出货明细实体
        /// </summary>
        public List<SaleOutboundOrderLine> Details { get; set; }
        /// <summary>
        /// SOID（CRM字段）保存即可
        /// </summary>
        public string SOID { get; set; }
    }
}
