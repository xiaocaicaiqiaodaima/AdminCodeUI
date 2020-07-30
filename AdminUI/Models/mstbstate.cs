using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace AdminUI.Models
{
   public class mstbstate
    {
        public int Id { get; set; }
        public string Ip_Address { get; set; }
        public string Mac { get; set; }
        public string Channel1 { get; set; }
        public string Channel2 { get; set; }
        public string Temperature { get; set; }
        public string Humidity { get; set; }

        public DateTime Monitor_Time { get; set; }
    }
}
