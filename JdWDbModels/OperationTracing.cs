using System;
using System.Collections.Generic;

namespace WasWebServerNew.JdWDbModels
{
    public partial class OperationTracing
    {
        public string Id { get; set; }
        public string User { get; set; }
        public string Source { get; set; }
        public string Operation { get; set; }
        public string Object { get; set; }
        public string ObjectValue { get; set; }
        public string Result { get; set; }
        public string Context { get; set; }
        public string Comments { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
