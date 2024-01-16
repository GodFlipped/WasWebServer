using System;

namespace WasWebServerCore.DataTransferObjects.SdsDto
{
    public partial class AlarmEventRecordDto
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }
        public string Object { get; set; }
        public int Status { get; set; }
        public int Grade { get; set; }
        public string Comments { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Code { get; set; }
    }
}
