using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StockManagementWebApp.DAL.Models;
using StockManagementWebApp.DAL.Models.ViewModels;

namespace StockManagementWebApp.DAL.Gateway
{
    public class ItemGateway :BaseGateway
    {
        public int Save(Item item)
        {
            string query = "INSERT INTO Items(Name,CategoryId,CompanyId,ReorderLevel,Quantity) VALUES(@name,@categoryId,@companyId,@reorderLevel,@quantity)";

            command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@name", item.Name);
            command.Parameters.AddWithValue("@categoryId", item.CategoryId);
            command.Parameters.AddWithValue("@companyId", item.CompanyId);
            command.Parameters.AddWithValue("@reorderLevel", item.ReorderLevel);
            command.Parameters.AddWithValue("@quantity", item.Quantity);
           

            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            connection.Close();
            return rowAffect;
        }



            public int UpdateById(ItemViewModel itemView)
        {
            string query = " UPDATE ItemsView  SET Quantity = Quantity +@quantity WHERE ItemId=@itemid ";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@quantity", itemView.Quantity);
          

            command.Parameters.AddWithValue("@itemid", itemView.ItemId);

            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            connection.Close();
            return rowAffect;
        }

            public List<ItemViewModel> GetAllItemsByCompany(int companyid)
            {
                string query = "SELECT ItemId,ItemName,CompanyName,ReorderLevel,Quantity FROM ItemsView WHERE CompanyId=@companyid";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@companyid",companyid);

                List<ItemViewModel> itemList = new List<ItemViewModel>();
                connection.Open();
               
                reader = command.ExecuteReader();


                while (reader.Read())
                {
                    ItemViewModel itemViewModel = new ItemViewModel();

                    itemViewModel.ItemId = Convert.ToInt32(reader["ItemId"]);
                    itemViewModel.ItemName = reader["ItemName"].ToString();
                    itemViewModel.CompanyName = reader["CompanyName"].ToString();

                    itemViewModel.ReorderLevel = Convert.ToInt32(reader["ReorderLevel"]);
                    itemViewModel.Quantity = Convert.ToInt32(reader["Quantity"]);

                    itemList.Add(itemViewModel);
                }

                connection.Close();

                return itemList;

            }
            public List<ItemViewModel> GetAllItemsByCategory(int categoryId)
            {
                string query = "SELECT ItemId,ItemName,CompanyName,ReorderLevel,Quantity FROM ItemsView WHERE CategoryId=@categoryId";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@categoryId", categoryId);

                List<ItemViewModel> itemList = new List<ItemViewModel>();
                connection.Open();
               
                reader = command.ExecuteReader();


                while (reader.Read())
                {
                    ItemViewModel itemViewModel = new ItemViewModel();

                    itemViewModel.ItemId = Convert.ToInt32(reader["ItemId"]);
                    itemViewModel.ItemName = reader["ItemName"].ToString();
                    itemViewModel.CompanyName = reader["CompanyName"].ToString();
                    itemViewModel.ReorderLevel = Convert.ToInt32(reader["ReorderLevel"]);
                    itemViewModel.Quantity = Convert.ToInt32(reader["Quantity"]);

                    itemList.Add(itemViewModel);
                }

                connection.Close();

                return itemList;

            }

            public List<ItemViewModel> GetAllItems()
            {
                string query = "SELECT ItemId,ItemName,CompanyName,CategoryName,ReorderLevel,Quantity FROM ItemsView ";
                command = new SqlCommand(query, connection);
               

                List<ItemViewModel> itemList = new List<ItemViewModel>();
                connection.Open();
              
                reader = command.ExecuteReader();


                while (reader.Read())
                {
                    ItemViewModel itemViewModel = new ItemViewModel();

                    itemViewModel.ItemId = Convert.ToInt32(reader["ItemId"]);
                    itemViewModel.ItemName = reader["ItemName"].ToString();
                    itemViewModel.CompanyName = reader["CompanyName"].ToString();
                    itemViewModel.CategoryName = reader["CategoryName"].ToString();

                    itemViewModel.Quantity = Convert.ToInt32(reader["Quantity"]);
                    itemViewModel.ReorderLevel = Convert.ToInt32(reader["ReorderLevel"]);
                    

                    itemList.Add(itemViewModel);
                }

                connection.Close();

                return itemList;

            }

            public ItemViewModel GetItemById(int itemid)
            {
                string query = "SELECT * FROM ItemsView WHERE ItemId =@itemid";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@itemid", itemid);
                connection.Open();
                reader = command.ExecuteReader();
                reader.Read();
                ItemViewModel itemViewModel = null;
                if (reader.HasRows)
                {
                    itemViewModel = new ItemViewModel();
                    itemViewModel.ItemId = Convert.ToInt32(reader["ItemId"]);
                    itemViewModel.ItemName = reader["ItemName"].ToString();
                    itemViewModel.Quantity = Convert.ToInt32(reader["Quantity"].ToString());
                    itemViewModel.ReorderLevel = Convert.ToInt32(reader["ReorderLevel"].ToString());


                }
                reader.Close();
                connection.Close();
                return itemViewModel;
            }
            public List<ItemViewModel> GetAllItemsByCompanyAndCategory(int companyId,int categoryId)
            {
                string query = "SELECT ItemId,ItemName,CompanyName,ReorderLevel,Quantity FROM ItemsView WHERE CompanyId=@companyId  AND CategoryId=@categoryId  ";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@companyId", companyId);
                command.Parameters.AddWithValue("@categoryId", categoryId);

                List<ItemViewModel> itemList = new List<ItemViewModel>();
                connection.Open();
               
                reader = command.ExecuteReader();


                while (reader.Read())
                {
                    ItemViewModel itemViewModel = new ItemViewModel();

                    itemViewModel.ItemId = Convert.ToInt32(reader["ItemId"]);
                    itemViewModel.ItemName = reader["ItemName"].ToString();
                    itemViewModel.CompanyName = reader["CompanyName"].ToString();
                    itemViewModel.ReorderLevel = Convert.ToInt32(reader["ReorderLevel"]);
                    itemViewModel.Quantity = Convert.ToInt32(reader["Quantity"]);

                    itemList.Add(itemViewModel);
                }

                connection.Close();

                return itemList;

            }
            public Item GetItemByItemId(int itemid)
            {
                string query = "SELECT Name,CategoryId,CompanyId,ReorderLevel FROM Items WHERE Id =@itemid";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@itemid", itemid);
                connection.Open();
                reader = command.ExecuteReader();
                reader.Read();
                Item item = null;
                if (reader.HasRows)
                {
                    item = new Item();
                    //item.Id = Convert.ToInt32(reader["Id"]);
                    item.Name = reader["Name"].ToString();
                    item.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                    item.CompanyId = Convert.ToInt32(reader["CompanyId"]);
                    item.ReorderLevel = Convert.ToInt32(reader["ReorderLevel"]);


                }
                reader.Close();
                connection.Close();
                return item;
            }
            public int UpdateByItemId(Item item)
            {
                string query = " UPDATE Items  SET  Name= @name,CategoryId=@categoryId,CompanyId=@companyId,ReorderLevel=@reorderLevel WHERE Id=@id ";
                command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", item.Id);
                command.Parameters.AddWithValue("@name", item.Name);
                command.Parameters.AddWithValue("@categoryId", item.CategoryId);
                command.Parameters.AddWithValue("@companyId", item.CompanyId);
                command.Parameters.AddWithValue("@reorderLevel", item.ReorderLevel);

                connection.Open();
                int rowAffect = command.ExecuteNonQuery();
                connection.Close();
                return rowAffect;
            }
            public int DeleteById(int id)
            {
                string query = "DELETE FROM Items WHERE Id = @id";
                command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                int rowAffect = command.ExecuteNonQuery();
                connection.Close();
                return rowAffect;
            }  

    }
}