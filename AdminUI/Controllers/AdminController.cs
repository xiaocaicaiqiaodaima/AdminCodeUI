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
        [Authorize]
        public IActionResult UserForm() => View();
        [Authorize]
        public IActionResult Organize() => View();
        [Authorize]
        public IActionResult OrganizeForm() => View();

        [Authorize]
        public IActionResult Role() => View();
        [Authorize]
        public IActionResult RoleForm() => View();
        [Authorize]
        public IActionResult Module() => View();
        [Authorize]
        public IActionResult ModuleForm() => View();
        [Authorize]
        public IActionResult Log() => View();

        public IActionResult HistoryInformation() => View();
        public IActionResult HistoryInformationForm() => View();
        public IActionResult Information() => View();

        public IActionResult HistoryWarn() => View();
        public IActionResult ProcessedWarn() => View();
        public IActionResult PendingWarn() => View();

        public IActionResult Items() => View();
        public IActionResult ItemsForm() => View();
    }
}