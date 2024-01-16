using System;

namespace WasWebServerCore.DataTransferObjects.SdsDto
{
    public partial class AlarmTypeRecordDto
    {
        public string Id { get; set; }
        public bool CanJumpConfirm { get; set; }
        public bool CanJumpHandle { get; set; }
        public string Name { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Code { get; set; }
    }
}
