using System;
namespace WasWebServerCore.SecondaryDataContext
{
    public partial class SorterParameter
    {
        public string Id { get; set; }
        public string ConnectionName { get; set; }
        public int StorageDb { get; set; }
        public int StartAddress { get; set; }
        public string ValueType { get; set; }
        public string Value { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
