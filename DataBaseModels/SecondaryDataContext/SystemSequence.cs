using System;
namespace WasWebServerCore.SecondaryDataContext
{
    public partial class SystemSequence
    {
        public string Id { get; set; }
        public string Prefix { get; set; }
        public int Value { get; set; }
        public int MaxValue { get; set; }
        public int MinValue { get; set; }
        public int IncreaseRate { get; set; }
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
