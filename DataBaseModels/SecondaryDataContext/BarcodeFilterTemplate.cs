﻿using System;
namespace WasWebServerCore.SecondaryDataContext
{
    public partial class BarcodeFilterTemplate
    {
        public string Id { get; set; }
        public string Value { get; set; }
        public string RegularValue { get; set; }
        public bool IsActive { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}