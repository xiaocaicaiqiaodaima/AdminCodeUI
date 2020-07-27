using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminUI.Code.Web;
using AdminUI.Date.Models;
using AdminUI.Date.Repostiory;
using AdminUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdminUI.Controllers.Api
{
    [Route("api/[controller]")]
    [Authorize(Roles = ("管理员"))]
    [ApiController]
    public class OrganizeController : ControllerBase
    {
        public IRepositoryBase<Sys_Organize> Repository { get; }

        readonly Paginated paginated = new Paginated();
        public OrganizeController(IRepositoryBase<Sys_Organize> repository)
        {
            Repository = repository;
        }
        // GET: api/<OrganizeController>
        [HttpGet]
        public object Get(int page, int limit)
        {
            paginated.page = page;
            paginated.limit = limit;
            var list = Repository.Query(paginated).Result;
            var ret = new { code = 0, msg = "", data = list, count = paginated.records };
            return ret.ToJson();
        }

        // GET api/<OrganizeController>/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            var ret = Repository.QueryById(id).Result;
            return ret.ToJson();
        }

        // POST api/<OrganizeController>
        [HttpPost]
        public object Post([FromBody] OrganizeModel organize)
        {
            var addorganize = new Sys_Organize
            {
                F_Id = Common.GuId(),
                F_ParentId = organize.F_ParentId,
                F_Layers = 2,
                F_FullName = organize.F_FullName,
                F_EnCode = organize.F_CategoryId,
              
                F_ManagerId = organize.F_ManagerId,
                F_CreatorTime = DateTime.Now
            };
            var ret = Repository.Add(addorganize).Result;
            return ret.ToJson();
        }

        // PUT api/<OrganizeController>/5
        [HttpPut]
        public object Put([FromBody] OrganizeModel organize)
        {
            var updateorganize = new Sys_Organize
            {
                F_Id = organize.F_Id,
                F_ParentId = organize.F_ParentId,
                F_Layers = organize.F_Layers,
                F_FullName = organize.F_FullName,
                F_EnCode = organize.F_CategoryId,
                F_ManagerId = organize.F_ManagerId,
            };
            var ret = Repository.Update(updateorganize).Result;
            return ret.ToJson();
        }

        // DELETE api/<OrganizeController>/5
        [HttpDelete("{id}")]
        public object Delete(string id)
        {
            var ret = Repository.DeleteById(id).Result;
            return ret.ToJson();
        }
    }
}
