using AdminUI.Date.Models;
using AdminUI.Date.Repostiory;
using AdminUI.Models;
using System.Collections.Generic;
using System.Linq;

namespace AdminUI.Controllers
{
    public class ClientsData
    {


        public List<ItemsModel> addchildren(List<Sys_Items> list, string id)
        {
            List<ItemsModel> itemsModels = new List<ItemsModel>();
            foreach (var item in list.Where(t => t.F_ParentId == id))
            {
                ItemsModel itemsModel = new ItemsModel();
                itemsModel.title = item.F_FullName;
                itemsModel.Id = item.F_Id;
                itemsModel.children = addchildren(list, item.F_Id);
                itemsModels.Add(itemsModel);
            }

            return itemsModels;
        }

        public object GetDataItemList(IRepositoryBase<Sys_ItemsDetail> ItemsDetail, IRepositoryBase<Sys_Items> Items)
        {
            var ItemDetaildata = ItemsDetail.Query().Result;
            var Itemsdata = Items.Query().Result;
            Dictionary<string, object> dictionaryItem = new Dictionary<string, object>();
            foreach (var item in Itemsdata)
            {
                var dataItemList = ItemDetaildata.FindAll(t => t.F_ItemId.Equals(item.F_Id));
                Dictionary<string, string> dictionaryItemList = new Dictionary<string, string>();
                foreach (var itemList in dataItemList)
                {
                    dictionaryItemList.Add(itemList.F_ItemCode, itemList.F_ItemName);
                }
                dictionaryItem.Add(item.F_EnCode, dictionaryItemList);
            }
            return dictionaryItem;
        }

        public object GetItemsList(IRepositoryBase<Sys_Items> Items)
        {
          
            var Itemsdata = Items.Query().Result;
            Dictionary<string, object> dictionary = new Dictionary<string, object>();

                foreach ( Sys_Items items in Itemsdata)
                {
                    var fieldItem = new
                    {
                        encode = items.F_EnCode,
                        fullname = items.F_FullName,
                        id = items.F_Id,
                        layers = items.F_Layers
                    };
                dictionary.Add(items.F_Id, fieldItem);
            }
              
            return dictionary;
        }


        public object GetOrganizeList(IRepositoryBase<Sys_Organize> Organize)
        {

            var data = Organize.Query().Result;
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            foreach (Sys_Organize item in data)
            {
                var fieldItem = new
                {
                    encode = item.F_EnCode,
                    fullname = item.F_FullName,
                    id = item.F_Id,
                    layers = item.F_Layers
                };
                dictionary.Add(item.F_Id, fieldItem);
            }
            return dictionary;
        }


        public object GetRoleList(IRepositoryBase<Sys_Role> Role)
        {
            var data = Role.Query(t => t.F_Category == 1).Result;
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            foreach (Sys_Role item in data)
            {
                var fieldItem = new
                {
                    encode = item.F_EnCode,
                    fullname = item.F_FullName,
                    id = item.F_Id
                };
                dictionary.Add(item.F_Id, fieldItem);
            }
            return dictionary;
        }

        public object GetDutyList(IRepositoryBase<Sys_Role> Role)
        {

            var data = Role.Query(t => t.F_Category == 2).Result;
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            foreach (Sys_Role item in data)
            {
                var fieldItem = new
                {
                    encode = item.F_EnCode,
                    fullname = item.F_FullName,
                    id = item.F_Id
                };
                dictionary.Add(item.F_Id, fieldItem);
            }
            return dictionary;
        }

        public object GetTarget(IRepositoryBase<Sys_Module> Module)
        {
            var data = Module.Query(t => t.F_Target == "expand").Result;
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            foreach (Sys_Module item in data)
            {
                var fieldItem = new
                {
                    encode = item.F_ParentId,
                    fullname = item.F_FullName,
                    id = item.F_Id
                };
                dictionary.Add(item.F_Id, fieldItem);
            }
            return dictionary;

        }


    }
}
