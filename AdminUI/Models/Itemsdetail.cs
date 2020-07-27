using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminUI.Models
{
    public class Itemsdetail
    {
        public string F_Id { get; set; }
        public string F_ItemId { get; set; }
        public string F_ItemCode { get; set; }
        public string F_ItemName { get; set; }
        public DateTime F_CreatorTime { get; set; }
        public int F_SortCode { get; set; }

        public string F_EnabledMark { get; set; }

    }
}
