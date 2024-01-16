using System;
using System.Collections.Generic;

namespace WasWebServerNew.JdWDbModels
{
    public partial class SorterMessageWorkTask
    {
        public string Id { get; set; }
        public int Type { get; set; }
        public string Connect { get; set; }
        public string Induct { get; set; }
        public string InductMode { get; set; }
        public DateTime? InductTime { get; set; }
        public string TrackingId { get; set; }
        public string Result { get; set; }
        public string CurrentShuteAddr { get; set; }
        public decimal Weight { get; set; }
        public int SerialNumber { get; set; }
        public int ParallelNumber { get; set; }
        public string ExecuteWorkTaskId { get; set; }
        public string OperatorName { get; set; }
        public string ObjectToHandle { get; set; }
        public int WorkTaskType { get; set; }
        public int Status { get; set; }
        public int SourceStatus { get; set; }
        public int TriggerMode { get; set; }
        public DateTime? FaultTime { get; set; }
        public DateTime? TimeOutTime { get; set; }
        public DateTime? CompleteTime { get; set; }
        public string Comments { get; set; }
        public string Results { get; set; }
        public string Executor { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
