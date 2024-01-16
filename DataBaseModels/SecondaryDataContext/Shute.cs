using System;
namespace WasWebServerCore.SecondaryDataContext
{
    public partial class Shute
    {
        public string Id { get; set; }
        public string ShuteType { get; set; }
        public string DisplayName { get; set; }
        public string DeviceName1 { get; set; }
        public string DeviceName2 { get; set; }
        public bool IsEnable { get; set; }
        public bool IsFull { get; set; }
        public bool IsActive { get; set; }
        public bool IsBind { get; set; }
        public string PhycialSorter { get; set; }
        public string LogicalSorter { get; set; }
        public string PackageNo { get; set; }
        public string TheLastPackageNo { get; set; }
        public int PackageNumber { get; set; }
        public int TheLastPackageNumber { get; set; }
        public string PrintId { get; set; }
        public string BackPrintId { get; set; }
        public string SpecialPackageNo { get; set; }
        public string PickingWallNumber { get; set; }
        public string BoxType { get; set; }
        public string AreaNo { get; set; }
        public string TagNum { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
