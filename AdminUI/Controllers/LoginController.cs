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


        //注销登录
        public async Task<IActionResult> Logout()
        {
            var loglist = new Sys_Log
            {
                F_Account = User.Identity.Name,
                F_NickName = User.Identity.Name,
                F_Type = "Logout",
                F_IPAddress = "",
                F_IPAddressName = "",
                F_ModuleName = "系统登录",
                F_Result = true,
                F_Description = "安全退出系统！",
                F_CreatorTime = DateTime.Now,
                F_Id = Common.GuId(),
                F_Date = DateTime.Now
            };
            var log = Logs.Add(loglist);
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");

        }

    }
}