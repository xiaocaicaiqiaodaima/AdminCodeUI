using System;
using System.Collections.Generic;

namespace AdminUI.Date.Models
{
    public partial class Sys_ModuleFormInstance
    {
        public string F_Id { get; set; }
        public string F_FormId { get; set; }
        public string F_ObjectId { get; set; }
        public string F_InstanceJson { get; set; }
        public int? F_SortCode { get; set; }
        public DateTime? F_CreatorTime { get; set; }
        public string F_CreatorUserId { get; set; }
    }
}
