using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminUI.Code.Web;
using AdminUI.Date.Models;
using AdminUI.Date.Repostiory;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace AdminUI.Controllers
{
    public class LoginController : Controller
    {
        public LoginController(IRepositoryBase<Sys_Log> logs)
        {
            Logs = logs;
        }

        public IRepositoryBase<Sys_Log> Logs { get; }

        public IActionResult Index()
        {
            return View();
        }




    }
}