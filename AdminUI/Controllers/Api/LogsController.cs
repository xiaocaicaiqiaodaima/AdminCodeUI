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

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdminUI.Controllers.Api
{
    [Route("api/[controller]")]
    public class LogsController : Controller
    {
        public IRepositoryBase<Sys_Log> Logs { get; }
        public IRepositoryBase<Sys_User> Userlog { get; }

        public LogsController(IRepositoryBase<Sys_Log> logs, IRepositoryBase<Sys_User> userlog)
        {
            Logs = logs;
            Userlog = userlog;
        }
        Paginated paginated = new Paginated();
        // GET: api/<controller>
        [HttpGet]
        public object Get(int page, int limit)
        {
            paginated.page = page;
            paginated.limit = limit;
            var ret = new{ code = 0, msg = "", data = Logs.Query().Result, count = paginated.records };
            return ret.ToJson();
        }

        // 注销登录
        [HttpGet("Logout")]
        public async Task<object> Logout(int id)
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
            return RedirectToAction("Index", "Login");
        }

    }
}
