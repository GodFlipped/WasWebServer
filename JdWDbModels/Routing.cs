using System;
using System.Collections.Generic;

namespace WasWebServerNew.JdWDbModels
{
    public partial class Routing
    {
        public string Id { get; set; }
        public string SorterPlan { get; set; }
        public string PhycialShute { get; set; }
        public string LogicalDestination { get; set; }
        public int? InternalPriority { get; set; }
        public int? ExternalPriority { get; set; }
        public int RoutingStrategy { get; set; }
        public string BoxSiteCode { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
