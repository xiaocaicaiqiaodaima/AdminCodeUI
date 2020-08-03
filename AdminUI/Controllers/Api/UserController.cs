
using AdminUI.Date.Models;
using AdminUI.Date.Repostiory;
using Microsoft.AspNetCore.Mvc;
using AdminUI.Code.Web;
using Microsoft.AspNetCore.Authorization;
using AdminUI.Models;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Linq;
using System.Text;

namespace AdminUI.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {

        public UserController(IRepositoryBase<Sys_User> repository, IRepositoryBase<Sys_Log> userlog)
        {
            Repository = repository;
            Userlog = userlog;
        }

        public IRepositoryBase<Sys_User> Repository { get; }



        Paginated paginated = new Paginated();
        private readonly IRepositoryBase<Sys_Log> Userlog;

        [HttpGet("Userlist")]
        public object Userlist(int page, int limit)
        {
            paginated.page = page;
            paginated.limit = limit;
            var lists = (Repository.Query(paginated).Result).Where(t => t.F_Account != "admin").Select(t => t).ToList();


            var ret = new { code = 0, msg = "", data = lists, count = paginated.records };
            return ret.ToJson();
        }

        // GET api/<controller>/5

        [HttpGet("{id}")]
        public string Get(string id)
        {
            var lists = Repository.QueryById(id).Result;
            return lists.ToJson();
        }

        // POST api/<controller>
        [Authorize(Roles = ("管理员"))]
        [HttpPost]
        public object Post(UserModel userModel)
        {
            var adduser = new Sys_User
            {
                F_Id = Common.GuId(),
                F_Account = userModel.F_Account,
                F_RealName = userModel.F_RealName,
                F_UserPassword = MD5Comm.Get32MD5One(DESEncrypt.Encrypt(userModel.F_UserPassword, "AdminUI")),
                F_MobilePhone = userModel.F_MobilePhone,
                F_Gender = userModel.F_Gender == "男" ? true : false,
                F_IsAdministrator = userModel.F_IsAdministrator == "on" ? true : false,
                F_EnabledMark = userModel.F_EnabledMark == "on" ? true : false,
                F_CreatorTime = DateTime.Now,
                F_ManagerId = "9f2ec079-7d0f-4fe2-90ab-8b09a8302aba",
                F_OrganizeId = userModel.F_OrganizeId,
                F_DepartmentId = userModel.F_DepartmentId,
                F_RoleId = userModel.F_RoleId,
                F_DutyId = userModel.F_DutyId
            };

            var ret = Repository.Add(adduser).Result;
            return ret.ToJson();

        }


        [HttpPost("Login")]
        public async Task<object> Login(LoginModel login,string cip,string cname)
        {
            var pss = MD5Comm.Get32MD5One(DESEncrypt.Encrypt(login.password, "AdminUI"));
            var list = Repository.Query(t => t.F_Account == login.userName).Result;
            var retpass = Repository.Query(t => t.F_UserPassword.Equals(pss)).Result.Count>0?true:false;
            var retname = list.Count > 0 ? true : false;

            var ret = retname == true && retpass == true ? true : false;
            var loglist = new Sys_Log
            {
                F_Account =list[0].F_Account,
                F_NickName = list[0].F_RealName,
                F_Type = "Login",
                F_IPAddress = cip,
                F_IPAddressName = cname,
                F_ModuleName = "系统登录",
                F_Result = ret,
                F_Description = ret == true? "验证成功!":"账号或密码错误!",
                F_CreatorTime = DateTime.Now,
                F_Id = Common.GuId(),
                F_Date = DateTime.Now
            };
            var log = Userlog.Add(loglist);
            
             
            if (ret)
            {
                //创建用户身份标识
                var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Name, login.userName),
                        new Claim(ClaimTypes.Role, list[0].F_IsAdministrator==true?"管理员":"普通用户"),
                         new Claim(ClaimTypes.Rsa, list[0].F_SecurityLevel.ToString())
                    };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties { };
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
               new ClaimsPrincipal(claimsIdentity), authProperties);

                return ret.ToJson();
            }
            else
            {
                return ret.ToJson();
            }
        }

        [HttpPost("Logins")]
        public object Logins([FromForm]LoginModel login)
        {
            var pss = MD5Comm.Get32MD5One(DESEncrypt.Encrypt(login.password, "AdminUI"));
            var ret = Repository.Query(t => t.F_Account == login.userName && t.F_UserPassword == pss).Result.Count > 0 ? true : false;
            return ret.ToJson();

        }


        [Authorize(Roles = ("管理员"))]
        [HttpPut]
        public object Put(UserModel userModel)
        {
            var adduser = new Sys_User
            {
                F_Id = userModel.F_Id,
                F_Account = userModel.F_Account,
                F_RealName = userModel.F_RealName,
                F_UserPassword = userModel.F_UserPassword,
                F_MobilePhone = userModel.F_MobilePhone,
                F_Gender = userModel.F_Gender == "男" ? true : false,
                F_IsAdministrator = userModel.F_IsAdministrator == "on" ? true : false,
                F_EnabledMark = userModel.F_EnabledMark == "on" ? true : false,
                F_CreatorTime = DateTime.Now,

                F_OrganizeId = userModel.F_OrganizeId,
                F_DepartmentId = userModel.F_DepartmentId,
                F_RoleId = userModel.F_RoleId,
                F_DutyId = userModel.F_DutyId

            };
            var ret = Repository.Update(adduser).Result;
            return ret.ToJson();
        }


        [Authorize(Roles = ("管理员"))]
        [HttpPut("updata")]
        public object updata([FromBody]UserModel userModel)
        {
            var adduser = new Sys_User
            {
                F_Id = userModel.F_Id,
                F_Account = userModel.F_Account,
                F_RealName = userModel.F_RealName,
                F_UserPassword = userModel.F_UserPassword,
                F_Email = userModel.F_Email,
                F_MobilePhone = userModel.F_MobilePhone,
                F_Gender = userModel.F_Gender == "0" ? true : false,
                F_IsAdministrator = userModel.F_IsAdministrator == "on" ? true : false,
                F_EnabledMark = userModel.F_EnabledMark == "on" ? true : false,
                F_CreatorTime = DateTime.Now,

                F_OrganizeId = userModel.F_OrganizeId,
                F_DepartmentId = userModel.F_DepartmentId,
                F_RoleId = userModel.F_RoleId,
                F_DutyId = userModel.F_DutyId

            };
            var ret = Repository.Update(adduser).Result;
            return ret.ToJson();
        }


        [Authorize(Roles = ("管理员"))]
        [HttpDelete("{id}")]
        public object Delete(string id)
        {

            var ret = Repository.DeleteById(id).Result;

            return ret.ToJson();
        }


    }
}