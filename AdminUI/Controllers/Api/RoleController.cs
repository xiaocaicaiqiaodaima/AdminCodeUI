using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminUI.Code.Web;
using AdminUI.Date.Models;
using AdminUI.Date.Repostiory;
using AdminUI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdminUI.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        public IRepositoryBase<Sys_Role> Repository { get; }

        public RoleController(IRepositoryBase<Sys_Role> repository)
        {
            Repository = repository;
        }
        Paginated paginated = new Paginated();
        // GET: api/<RoleController>
        [HttpGet]
        public object Get(int page, int limit)
        {
            paginated.page = page;
            paginated.limit = limit;
            var list =  Repository.Query(paginated).Result;
            var ret = new { code = 0, msg = "", data = list, count = paginated.records };
            return ret.ToJson();
        }

        // GET api/<RoleController>/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            var ret = Repository.QueryById(id).Result;
            return ret.ToJson();
        }

        // POST api/<RoleController>
        [HttpPost]
        public object Post([FromBody] RoleModel role)
        {
           var addrole = new Sys_Role { 
            F_Id= Common.GuId(),
            F_OrganizeId=role.F_OrganizeId,
            F_Category=role.F_Category,
            F_EnCode=role.F_EnCode,
            F_FullName=role.F_FullName,
            F_Type=role.F_Type,
            F_SortCode=role.F_SortCode,
            F_CreatorTime=DateTime.Now           
           };
            var ret = Repository.Add(addrole).Result;
            return ret.ToJson();
        }

        // PUT api/<RoleController>
        [HttpPut]
        public object Put([FromBody] RoleModel role)
        {
            var updaterole = new Sys_Role
            {
                F_Id =role.F_Id,
                F_OrganizeId = role.F_OrganizeId,
                F_Category = role.F_Category,
                F_EnCode = role.F_EnCode,
                F_FullName = role.F_FullName,
                F_Type = role.F_Type,
                F_SortCode = role.F_SortCode
               
            };
            var ret = Repository.Update(updaterole).Result;
            return ret.ToJson();

        }

        // DELETE api/<RoleController>/5
        [HttpDelete("{id}")]
        public object Delete(string id)
        {
            var ret = Repository.DeleteById(id).Result;
            return ret.ToJson();

        }
    }
}
