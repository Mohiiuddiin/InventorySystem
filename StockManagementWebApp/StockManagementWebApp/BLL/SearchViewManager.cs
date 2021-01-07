using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StockManagementWebApp.DAL.Gateway;
using StockManagementWebApp.DAL.Models.ViewModels;

namespace StockManagementWebApp.BLL
{
    public class SearchViewManager
    {
        SearchViewGateway searchViewGateway=new SearchViewGateway();

        public List<SearchByDateViewModel> GetAllSalesList(string fromdate, string todate)
        {
 
            return searchViewGateway.GetAllSalesList(fromdate, todate);
        }
    }
}