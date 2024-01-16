﻿using System;
namespace WasWebServerCore.SecondaryDataContext
{
    public partial class PackageIndia
    {
        public string Id { get; set; }
        public string ShuteId { get; set; }
        public string PackageNo { get; set; }
        public string WaitPackageNo { get; set; }
        public int PackageNumber { get; set; }
        public int Status { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
