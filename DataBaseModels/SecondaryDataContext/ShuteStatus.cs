using System;
namespace WasWebServerCore.SecondaryDataContext
{
    public partial class ShuteStatus
    {
        public string Id { get; set; }
        public string ShuteType { get; set; }
        public string DisplayName { get; set; }
        public bool IsEnable { get; set; }
        public bool IsFull { get; set; }
        public bool IsActive { get; set; }
        public string PhycialSorter { get; set; }
        public string LogicalSorter { get; set; }
        public string CutoffTimings { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
