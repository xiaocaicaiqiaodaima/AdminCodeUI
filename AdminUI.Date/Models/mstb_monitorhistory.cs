using System;
using System.Collections.Generic;
using System.Text;

namespace AdminUI.Date.Models
{
   public partial class mstb_monitorhistory
    {
        public long ID { get; set; }
        public string Ip_Address { get; set; }
        public string Mac { get; set; }
        public string Monitor_Name { get; set; }
        public string Monitor_Value { get; set; }
        public string Unit { get; set; }
        public DateTime Monitor_Time { get; set; }
        public string Remark { get; set; }

    }
}
