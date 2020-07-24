using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminUI.Models
{
    public class ItemsModel
    {
        public string title { get; set; }
        public string Id { get; set; }

        public IList<ItemsModel> children=new List<ItemsModel>();
    }
}
