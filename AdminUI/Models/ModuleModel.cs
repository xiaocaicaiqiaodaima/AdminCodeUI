using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminUI.Models
{
    public class ModuleModel
    {
        public string F_Id { get; set; }
        public string F_ParentId { get; set; }
        public string F_FullName { get; set; }
        public string F_Fname { get; set; }
        public string F_Icon { get; set; }
        public string F_UrlAddress { get; set; }
        public string F_Target { get; set; }
        public string F_IsMenu { get; set; }
        public string F_IsExpand { get; set; }
        public string F_IsPublic { get; set; }
        public string F_AllowEdit { get; set; }
        public string F_AllowDelete { get; set; }
        public string F_EnabledMark { get; set; }
        public DateTime F_CreatorTime { get; set; }
    }
}
