using System;
using System.Collections.Generic;

namespace WasWebServerCore.WasDto
{
    public class ProductionOrder
    {
        public string OrderNo { get; set; }
        public List<OrderLine> OrderLines { get; set; }
        /// <summary>
        /// Add 添加 Delete 删除
        /// </summary>
        public string Operation { get; set; }
        /// <summary>
        /// 定制号（用于定制）
        /// </summary>
        public string PO { get; set; }
        /// <summary>
        /// 加工中心
        /// </summary>
        public string Department { get; set; }
        /// <summary>
        /// 开工日期,接口发送过来接收保存即可
        /// </summary>
        public DateTime PlanStartDate { get; set; }
        /// <summary>
        /// 仓库编码，接收发送过来接收保存即可
        /// </summary>
        public string Wh { get; set; }
        /// <summary>
        /// 是否是散装产品，接收保存即可
        /// </summary>
        public bool IsBulkProduct { get; set; }
        /// <summary>
        /// 创建人，接收保存即可
        /// </summary>
        public string CreateUser { get; set; }
    }
}
