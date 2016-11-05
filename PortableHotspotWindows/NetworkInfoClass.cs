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
        //First String is the network MAC Adress
        public List<String> ConnectedClients = new List<String>();
    }
}
