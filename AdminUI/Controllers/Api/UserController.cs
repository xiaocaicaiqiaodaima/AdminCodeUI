
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

namespace AdminUI.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {

        public UserController(IRepositoryBase<Sys_User> repository)
        {
            Repository = repository;

        }

        public IRepositoryBase<Sys_User> Repository { get; }


        Paginated paginated = new Paginated();
        [HttpGet("Userlist")]
        public object Userlist(int page, int limit)
        {
            paginated.page = page;
            paginated.limit = limit;
            var lists = Repository.Query(paginated).Result;
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
        [Authorize]
        [HttpPost]
        public object Post(UserModel userModel)
        {
            var adduser = new Sys_User
            {
                F_Id = Common.GuId(),
                F_Account = userModel.F_Account,
                F_RealName = userModel.F_RealName,
                F_UserPassword = userModel.F_UserPassword,
                F_MobilePhone = userModel.F_MobilePhone,
                F_Gender = userModel.F_Gender== "男" ? true : false,
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
        public async Task<object> Login(LoginModel login)
        {
            var pss = MD5Comm.Get32MD5One(DESEncrypt.Encrypt(login.password,"AdminUI"));
           
             var list = Repository.Query(t => t.F_Account == login.userName && t.F_UserPassword== pss).Result;
            var ret = list.Count > 0 ? true : false;

            if (ret)
            {
                //创建用户身份标识
                var claims = new List<Claim>()
                    {

                        new Claim(ClaimTypes.Name, login.userName),
                        new Claim(ClaimTypes.Role, list[0].F_IsAdministrator==true?"管理员":"普通用户"),
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


        [Authorize]
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
                F_Gender = userModel.F_Gender=="男"?true:false,
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


        [Authorize]
        [HttpPut("updata")]
        public object updata([FromBody]UserModel userModel)
        {
            var adduser = new Sys_User
            {
                F_Id = userModel.F_Id,
                F_Account = userModel.F_Account,
                F_RealName = userModel.F_RealName,
                F_UserPassword = userModel.F_UserPassword,
                F_MobilePhone = userModel.F_MobilePhone,
                F_Gender = userModel.F_Gender == "女"?true : false,
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


        [Authorize]
        [HttpDelete("id")]
        public object Delete(string id)
        {

            var ret = Repository.DeleteById(id).Result;

            return ret.ToJson();
        }


    }
}