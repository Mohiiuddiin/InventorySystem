using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using StockManagementWebApp.DAL.Gateway;
using StockManagementWebApp.DAL.Models;
using StockManagementWebApp.DAL.Models.ViewModels;

namespace StockManagementWebApp.BLL
{
    public class ItemManager
    {
        ItemGateway itemGateWay=new ItemGateway();

        public string Save(Item item)
        {
            int rowAffect = itemGateWay.Save(item);
            if (rowAffect > 0)
            {
                return "Saved successfuly";
            }
            else
            {
                return "Save Failed";
            }
        }

        public string UpdateById(ItemViewModel itemView)
        {
            if (itemView.Quantity<0)
            {
                return "Input Positive Quantity";
            }
            else
            {
                int rowAffect = itemGateWay.UpdateById(itemView);
                if (rowAffect > 0)
                {
                    return "Update successfuly";
                }
                else
                {
                    return "Update Failed";
                }
            }
          
        }

        public string DeleteById(int id)
        {
            int rowAffect = itemGateWay.DeleteById(id);
            if (rowAffect > 0)
            {
                return "Delete successful";
            }
            else
            {
                return "Delete Failed";
            }
        }

        public List<ItemViewModel> GetAllItemsByCompany(int companyid)
        {

            return itemGateWay.GetAllItemsByCompany(companyid);

        }

        public ItemViewModel GetItemById(int itemid)
        {
            return itemGateWay.GetItemById(itemid);
        }

        public List<ItemViewModel> GetAllItemsByCategory(int categoryId)
        {
            return itemGateWay.GetAllItemsByCategory(categoryId);

        }

        public List<ItemViewModel> GetAllItems()
        {
            return itemGateWay.GetAllItems();
        }

        public List<ItemViewModel> GetAllItemsByCompanyAndCategory(int companyId, int categoryId)
        {
            return itemGateWay.GetAllItemsByCompanyAndCategory(companyId, categoryId);
        }

        public Item GetItemByItemId(int itemid)
        {
            return itemGateWay.GetItemByItemId(itemid);
        }

        public string UpdateByItemId(Item item)
        {
            
                int rowAffect= itemGateWay.UpdateByItemId(item);
                if (rowAffect > 0)
                {
                    return "Update Succesful";
                }
                else
                {
                    return "Update Failed";   
                }
           
        }

    }
}