using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminUI.Code.Model;
using AdminUI.Code.Web;
using AdminUI.Date.Models;
using AdminUI.Date.Repostiory;
using AdminUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace AdminUI.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class ModuleController : Controller
    {
        public IRepositoryBase<Sys_Module> Repository { get; }

        public ModuleController(IRepositoryBase<Sys_Module> repository)
        {
            Repository = repository;
        }

        // GET: api/<controller>
        [HttpGet]
        public object Get()
        {
            var list = Repository.Query().Result;
            var ret = ToMenuJson(list, "0");
            return Content(ret);
        }


        [HttpGet("GetTarget")]
        public object GetTarget()
        {
            var list = Repository.Query(t => t.F_Target == "expand").Result;
            return list.ToJson();

        }
        private string ToMenuJson(List<Sys_Module> data, string parentId)
        {
            StringBuilder sbJson = new StringBuilder();
            sbJson.Append("[");
            List<Sys_Module> entitys = data.FindAll(t => t.F_ParentId == parentId);
            if (entitys.Count > 0)
            {
                foreach (var item in entitys)
                {
                    string strJson = item.ToJson();
                    strJson = strJson.Insert(strJson.Length - 1, ",\"children\":" + ToMenuJson(data, item.F_Id) + "");
                    sbJson.Append(strJson + ",");
                }
                sbJson = sbJson.Remove(sbJson.Length - 1, 1);
            }
            sbJson.Append("]");
            return sbJson.ToString();
        }


        // PUT api/<controller>/
        [Authorize]
        [HttpPut]
        public object Put(ModuleModel moduleModel)
        {
            var list = new Sys_Module
            {
                F_Id = moduleModel.F_Id,
                F_ParentId = moduleModel.F_ParentId,
                F_FullName = moduleModel.F_FullName,
                F_Icon = moduleModel.F_Icon==""? "&#xe63c;" : moduleModel.F_Icon,
                F_UrlAddress = moduleModel.F_UrlAddress,
                F_Target = moduleModel.F_Target,
                F_IsMenu = moduleModel.F_IsMenu == "on" ? true : false,
                F_IsPublic = moduleModel.F_IsPublic == "on" ? true : false,
                F_IsExpand = moduleModel.F_IsExpand == "on" ? true : false,
                F_AllowEdit = moduleModel.F_AllowEdit == "on" ? true : false,
                F_AllowDelete = moduleModel.F_AllowDelete == "on" ? true : false,
                F_EnabledMark = moduleModel.F_EnabledMark == "on" ? true : false,
                F_CreatorTime = DateTime.Now

            };
            var ret = Repository.Update(list).Result;
            return ret.ToJson();
        }


        [Authorize]
        [HttpPost("Add")]
        public object Add(ModuleModel moduleModel)
        {
            var list = new Sys_Module
            {
                F_Id = Common.GuId(),
                F_ParentId = moduleModel.F_ParentId,
                F_FullName = moduleModel.F_FullName,
                F_Icon = moduleModel.F_Icon == null ? "layui-icon-website" : moduleModel.F_Icon,
                F_UrlAddress = moduleModel.F_UrlAddress,
                F_Target = moduleModel.F_Target,
                F_IsMenu = moduleModel.F_IsMenu == "on" ? true : false,
                F_IsPublic = moduleModel.F_IsPublic == "on" ? true : false,
                F_IsExpand = moduleModel.F_IsExpand == "on" ? true : false,
                F_AllowEdit = moduleModel.F_AllowEdit == "on" ? true : false,
                F_AllowDelete = moduleModel.F_AllowDelete == "on" ? true : false,
                F_EnabledMark = moduleModel.F_EnabledMark == "on" ? true : false,
                F_CreatorTime = DateTime.Now


            };
            var ret = Repository.Add(list).Result;
            return ret.ToJson();
        }
        // DELETE api/<controller>/5
        [Authorize]
        [HttpDelete("{id}")]
        public object Delete(string id)
        {

            var ret = Repository.DeleteById(id).Result;
            return ret.ToJson();
        }

    }
}