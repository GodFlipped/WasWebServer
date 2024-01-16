using System;
namespace WasWebServerCore.SecondaryDataContext
{
    public partial class DeviceMap
    {
        public string Id { get; set; }
        public string PickingWallNumber { get; set; }
        public string SourceDeviceAddress { get; set; }
        public string DestinationDeviceAddress { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
