using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdminUI.Controllers
{
    public class AdminController : Controller
    {
        [Authorize]
        public IActionResult Index() => View();
        [Authorize]
        public IActionResult GisMap() => View();
        [Authorize]
        public IActionResult Users() => View();
        [Authorize(Roles = ("管理员"))]
        public IActionResult UserForm() => View();
        [Authorize(Roles = ("管理员"))]
        public IActionResult Organize() => View();
        [Authorize(Roles = ("管理员"))]
        public IActionResult OrganizeForm() => View();

        [Authorize(Roles = ("管理员"))]
        public IActionResult Role() => View();
        [Authorize(Roles = ("管理员"))]
        public IActionResult RoleForm() => View();
        [Authorize(Roles = ("管理员"))]
        public IActionResult Module() => View();
        [Authorize(Roles = ("管理员"))]
        public IActionResult ModuleForm() => View();
        [Authorize(Roles = ("管理员"))]
        public IActionResult Log() => View();

        public IActionResult HistoryInformation() => View();
        public IActionResult HistoryInformationForm() => View();
        public IActionResult Information() => View();

        public IActionResult HistoryWarn() => View();
        public IActionResult ProcessedWarn() => View();
        public IActionResult PendingWarn() => View();
        [Authorize(Roles = ("管理员"))]
        public IActionResult Items() => View();
        public IActionResult ItemsForm() => View();
    }
}