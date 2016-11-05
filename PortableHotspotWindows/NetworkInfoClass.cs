using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableHotspotWindows
{
    class NetworkInfoClass
    {
        public String NetworkStatus { get; set; }
        public String SSID { get; set; }
        public String NumOfClients { get; set; }
        public String Key { get; set; }
        public List<String> ConnectedClients { get; set; }
    }
}
