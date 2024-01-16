﻿using System;
using System.Collections.Generic;

namespace WasWebServerNew.JdWDbModels
{
    public partial class SystemParameter
    {
        public string Id { get; set; }
        public string Value { get; set; }
        public string Template { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
