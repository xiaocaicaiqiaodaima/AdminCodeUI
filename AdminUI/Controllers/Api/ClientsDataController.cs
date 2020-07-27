using System;
using System.Collections.Generic;
using AdminUI.Code.Web;
using AdminUI.Date.Models;
using AdminUI.Date.Repostiory;
using AdminUI.Models;
using Microsoft.AspNetCore.Mvc;

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

       
        [HttpGet("GetItems")]
        public object GetItems(int page, int limit) {

      
            var list = Items.Query().Result;

            List<ItemsModel> itemsModels = new List<ItemsModel>();
            foreach (var item in list)
            {
                if (item.F_ParentId=="0")
                {
                    ItemsModel itemsModel = new ItemsModel();
                    itemsModel.title = item.F_FullName;
                    itemsModel.Id= item.F_Id;
                    itemsModel.children = Clients.addchildren(list,item.F_Id);
                    itemsModels.Add(itemsModel);
                }
            }
            return itemsModels.ToJson();
           
        }


        [HttpPut("ItemsDetailUpdate")]
        public object ItemsDetailUpdate(Itemsdetail itemsModel) {
            var list = new Sys_ItemsDetail {
                F_ItemName = itemsModel.F_ItemName,
                F_CreatorTime = DateTime.Now,
                F_Id = itemsModel.F_Id,
                F_ItemId = itemsModel.F_ItemId,
                F_ItemCode = itemsModel.F_ItemCode,
                F_SortCode = int.Parse(itemsModel.F_SortCode),
                F_EnabledMark = true
            };
            var ret = ItemsDetail.Update(list).Result;
            return ret;
        }

        [HttpPost("ItemsDetailAdd")]
        public object ItemsDetailAdd([FromBody]Itemsdetail itemsModel)
        {
            var list = new Sys_ItemsDetail
            {
                F_ItemName = itemsModel.F_ItemName,
                F_CreatorTime = DateTime.Now,
                F_Id = Common.GuId(),
                F_ItemId = itemsModel.F_ItemId,
                F_ItemCode = itemsModel.F_ItemCode,
                F_SortCode = int.Parse(itemsModel.F_SortCode),
                F_EnabledMark = true
            };
            var ret = ItemsDetail.Add(list).Result;
            return ret;
        }


        [HttpDelete("ItemsDetailDelete/{id}")]
        public object ItemsDetailDelete(string id) {
            var ret = ItemsDetail.DeleteById(id).Result;
            return ret.ToJson();
        }


        [HttpGet("GetItemsDetail")]
        public object GetItemsDetail(int page, int limit,string id)
        {
            List<Sys_ItemsDetail> _ItemsDetail = new List<Sys_ItemsDetail>();
            var list = ItemsDetail.Query().Result;
            foreach (var item in list)
            {
                Sys_ItemsDetail sys_Items = new Sys_ItemsDetail();
                if (item.F_ItemId==id)
                {
                    sys_Items.F_Id = item.F_Id;
                    sys_Items.F_ItemId = item.F_ItemId;
                    sys_Items.F_ItemCode = item.F_ItemCode;
                    sys_Items.F_ItemName = item.F_ItemName;
                    sys_Items.F_SortCode = item.F_SortCode;
                    sys_Items.F_CreatorTime = item.F_CreatorTime;
                    sys_Items.F_EnabledMark = item.F_EnabledMark;
                
                    _ItemsDetail.Add(sys_Items);
                }
            }
            var data = new { code = 0, msg = "", data = _ItemsDetail, count = _ItemsDetail.Count };
            return data.ToJson();
        }

        // GET: api/<controller>
        [HttpGet]
        public ActionResult GetClientsDataJson()
        {
            var data = new
            {
                dataItems = Clients.GetDataItemList(ItemsDetail,Items),
                Items= Clients.GetItemsList(Items),
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
