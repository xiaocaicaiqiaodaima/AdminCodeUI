using System;
using System.Collections.Generic;
using System.Text;

namespace AdminUI.Code.Model
{
   public class TreeSelectModel
    {
        public string id { get; set; }
        public string text { get; set; }
        public string parentId { get; set; }
        public object data { get; set; }
    }
}
