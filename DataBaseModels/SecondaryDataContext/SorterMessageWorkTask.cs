using System;
namespace WasWebServerCore.SecondaryDataContext
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
        public string OperatorName { get; set; }
        public string ActivePackageNo { get; set; }
        public string ObjectToHandle { get; set; }
        public int WorkTaskType { get; set; }
        public int Status { get; set; }
        public int SourceStatus { get; set; }
        public int? InternalPriority { get; set; }
        public int? ExternalPriority { get; set; }
        public int TriggerMode { get; set; }
        public int SourceTriggerMode { get; set; }
        public DateTime? TriggerFixedTime { get; set; }
        public int? TriggerIntervalTime { get; set; }
        public string ReadyBy { get; set; }
        public DateTime? ReadyTime { get; set; }
        public string ReleaseBy { get; set; }
        public DateTime? ReleaseTime { get; set; }
        public string ActiveBy { get; set; }
        public DateTime? ActiveTime { get; set; }
        public string CancelledBy { get; set; }
        public DateTime? CancelledTime { get; set; }
        public string TerminatedBy { get; set; }
        public DateTime? TerminatedTime { get; set; }
        public string SuspendedBy { get; set; }
        public DateTime? SuspendedTime { get; set; }
        public string ResumeBy { get; set; }
        public DateTime? ResumeTime { get; set; }
        public DateTime? CompleteTime { get; set; }
        public DateTime? FaultTime { get; set; }
        public DateTime? TimeOutTime { get; set; }
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
