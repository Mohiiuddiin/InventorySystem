using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace StockManagementWebApp.DAL.Gateway
{
    public class CategoryGateway : BaseGateway
    {

        public int save(Category category)
        {
            string query = "INSERT INTO Category(Name) VALUES(@name)";
            command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@name", category.Name);

            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            connection.Close();
            return rowAffect;

        }

        public bool IsExistCategoryName(string name)
        {
            string query = "SELECT * FROM Category WHERE Name=@Name";

            command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", name);

            connection.Open();
            reader = command.ExecuteReader();
            bool isExist = reader.HasRows;
            connection.Close();
            return isExist;
        }

        public List<Category> GetAllCategories()
        {
            string query = "SELECT * FROM Category";
            command = new SqlCommand(query, connection);

            List<Category> categoryList = new List<Category>();
            connection.Open();

            reader = command.ExecuteReader();


            while (reader.Read())
            {
                Category category = new Category();

                category.Id = Convert.ToInt32(reader["Id"]);
                category.Name = reader["Name"].ToString();

                categoryList.Add(category);
            }

            connection.Close();

            return categoryList;

        }

        public Category GetCategoryById(int id)
        {
            string query = "SELECT * FROM Category WHERE Id =@id";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            reader = command.ExecuteReader();
            reader.Read();
            Category company = null;
            if (reader.HasRows)
            {
                company = new Category();
                company.Id = Convert.ToInt32(reader["Id"]);
                company.Name = reader["Name"].ToString();

            }
            reader.Close();
            connection.Close();
            return company;
        }

        public int UpdateById(Category category)
        {
            string query = "Update Category SET Name = @name WHERE Id = @id";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", category.Name);
            command.Parameters.AddWithValue("@id", category.Id);

            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            connection.Close();
            return rowAffect;
        }

        public int DeleteById(int id)
        {
            string query = "DELETE FROM Category WHERE Id = @id";
            command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", id);

            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            connection.Close();
            return rowAffect;
        }
    }
}