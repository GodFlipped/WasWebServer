using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WasWebServerNew.Infrastructure.OPC
{
    public class OpcUaSetting
    {
        public string EndpointUri { get; set; }

        public List<OpcUaChannelItem> OpcUaChannelItems { get; set; }
    }

    public class OpcUaChannelItem
    {
        public string DisplayName { get; set; }

        public List<OpcUaDeviceItem> Devices { get; set; }
    }

    public class OpcUaDeviceItem 
    {
        public string DisplayName { get; set; }

        public List<string> TagsName { get; set; }
    }

   
}
