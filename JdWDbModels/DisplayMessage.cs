using System;
using System.Collections.Generic;

namespace WasWebServerNew.JdWDbModels
{
    public partial class DisplayMessage
    {
        public string Id { get; set; }
        public string ObjectToHandle { get; set; }
        public string Source { get; set; }
        public string SourceAddress { get; set; }
        public string DestinationAddress { get; set; }
        public string MessageType { get; set; }
        public string Message { get; set; }
        public string Comments { get; set; }
        public int Status { get; set; }
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
        public DateTime? CompleteTime { get; set; }
        public DateTime? FaultTime { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
