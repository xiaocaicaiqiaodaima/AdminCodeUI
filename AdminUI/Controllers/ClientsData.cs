﻿using AdminUI.Date.Models;
using AdminUI.Date.Repostiory;
using System.Collections.Generic;

namespace AdminUI.Controllers
{
    public class ClientsData
    {

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