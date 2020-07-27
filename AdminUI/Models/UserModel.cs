using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminUI.Models
{
    public class UserModel
    {
        public string F_Id { get; set; }
        public string F_Account { get; set; }
        public string F_RealName { get; set; }

        public string F_UserPassword { get; set; }
        public string F_Gender { get; set; }

        public string F_MobilePhone { get; set; }
        public string F_Email { get; set; }
        public string F_OrganizeId { get; set; }
        public string F_DepartmentId { get; set; }
        public string F_RoleId { get; set; }
        public string F_DutyId { get; set; }
        public string F_IsAdministrator { get; set; }

        public string F_EnabledMark { get; set; }

    }
}
