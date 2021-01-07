using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagementWebApp.DAL.Models.ViewModels
{
    public class SearchByDateViewModel
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string CompanyName { get; set; }
        public int Quantity { get; set; }
        public string Date { get; set; }
    }
}