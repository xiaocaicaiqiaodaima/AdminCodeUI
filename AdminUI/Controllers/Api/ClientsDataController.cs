using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminUI.Code.Web;
using AdminUI.Date.Models;
using AdminUI.Date.Repostiory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdminUI.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsDataController : Controller
    {
        public IRepositoryBase<Sys_Role> Role { get; }
        public IRepositoryBase<Sys_Organize> Organize { get; }
        public IRepositoryBase<Sys_ItemsDetail> ItemsDetail { get; }
        public IRepositoryBase<Sys_Items> Items { get; }
        public IRepositoryBase<Sys_Module> Module { get; }
        ClientsData Clients = new ClientsData();
        public ClientsDataController(
            IRepositoryBase<Sys_Role> Role
            ,IRepositoryBase<Sys_Organize> Organize
            , IRepositoryBase<Sys_ItemsDetail> ItemsDetail
            ,IRepositoryBase<Sys_Items> Items
            ,IRepositoryBase<Sys_Module> Module
            )
        {
            this.Role = Role;
            this.Organize = Organize;
            this.ItemsDetail = ItemsDetail;
            this.Items = Items;
            this.Module = Module;
        }
        // GET: api/<controller>
        [HttpGet]
        public ActionResult GetClientsDataJson()
        {
            var data = new
            {
                dataItems = Clients.GetDataItemList(ItemsDetail,Items),
                organize = Clients.GetOrganizeList(Organize),
                role = Clients.GetRoleList(Role),
                duty = Clients.GetDutyList(Role),
                user = "",
                module= Clients.GetTarget(Module)

            };
            return Content(data.ToJson());
        }


      
    }
}
