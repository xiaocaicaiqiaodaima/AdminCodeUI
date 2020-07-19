using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminUI.Models
{
    public class RoleModel
    {
        public string F_Id { get; set; }
        public string F_OrganizeId { get; set; }
        public int? F_Category { get; set; }
        public string F_EnCode { get; set; }
        public string F_FullName { get; set; }
        public string F_Type { get; set; }
        public string F_SortCode { get; set; }
        public string F_AllowEdit { get; set; }
        public string F_AllowDelete { get; set; }
        public string F_EnabledMark { get; set; }
        public string F_CreatorTime { get; set; }
    }
}
