using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StockManagementWebApp.DAL.Gateway;
using StockManagementWebApp.DAL.Models;

namespace StockManagementWebApp.BLL
{
    public class StockoutManager
    {
        StockoutGateway stockoutGateway=new StockoutGateway();
        public string save(Stockout stockout)
        {
            if (stockout.Quantity>0)
            {
                int rowAffect = stockoutGateway.save(stockout);
                if (rowAffect > 0)
                {
                    return "save successfuly";
                }
                else
                {
                    return "Save Failed";
                }
               
            }
            else
            {
                return "Save Failed,Please insert positive Quantity Value";
            }
           
        }

        public string UpdateById(Stockout stockout)
        {
            if (stockout.Quantity>0)
            {
                int rowAffect = stockoutGateway.UpdateById(stockout);
                if (rowAffect > 0)
                {
                    return "save successfuly";
                }
                else
                {
                    return "Save Failed";
                }
              
            }
            else
            {
                return "Save Failed,Please insert positive Quantity Value";
            }
          
            
        }
    }
}