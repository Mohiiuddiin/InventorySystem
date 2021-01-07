using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StockManagementWebApp.DAL.Models;
using StockManagementWebApp.DAL.Models.ViewModels;

namespace StockManagementWebApp.DAL.Gateway
{
    public class SearchViewGateway :BaseGateway
    {
        //public  SearchsalesbyDate(string fromdate, string todate)
        //{
        //    string query = "SELECT * FROM StockOut WHERE Date between @fromdate and @todate";

        //    command = new SqlCommand(query, connection);

        //    command.Parameters.AddWithValue("@fromdate", fromdate);
        //    command.Parameters.AddWithValue("@fromdate", todate);

        //    connection.Open();
        //    reader = command.ExecuteReader();
        //    bool isExist = reader.HasRows;
        //    connection.Close();
        //    return isExist;
        //}
        public List<SearchByDateViewModel> GetAllSalesList(string fromdate, string todate)
        {
            string query = "SELECT Id,ItemName,CompanyName,Quantity FROM SearchByDateView WHERE Date BETWEEN @fromdate AND @todate";
            command=new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@fromdate", fromdate);
            command.Parameters.AddWithValue("@todate", todate);

            List<SearchByDateViewModel> searchByDateViewModelsList = new List<SearchByDateViewModel>();
            connection.Open();

            reader = command.ExecuteReader();
            

            while (reader.Read())
            {
                SearchByDateViewModel searchByDateViewModel = new SearchByDateViewModel();
                searchByDateViewModel.Id = Convert.ToInt32(reader["Id"]);
                searchByDateViewModel.ItemName = reader["ItemName"].ToString();
                searchByDateViewModel.CompanyName = reader["CompanyName"].ToString();
                searchByDateViewModel.Quantity = Convert.ToInt32(reader["Quantity"]);
                searchByDateViewModelsList.Add(searchByDateViewModel);
            }
            reader.Close();
            connection.Close();

            return searchByDateViewModelsList;

        }

    }
}