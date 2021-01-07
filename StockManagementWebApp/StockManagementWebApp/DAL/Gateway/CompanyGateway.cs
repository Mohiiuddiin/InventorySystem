using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using StockManagementWebApp.DAL.Models;

namespace StockManagementWebApp.DAL.Gateway
{
    public class CompanyGateway :BaseGateway
    {
        

        public int save(Company company)
        {
            string query = "INSERT INTO Company(Name) VALUES(@name)";
            command=new SqlCommand(query,connection);

            command.Parameters.AddWithValue("@name", company.Name);

            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            connection.Close();
            return rowAffect;

        }

        public bool IsExistCategoryName(string name)
        {
            string query="SELECT * FROM Company WHERE Name=@Name";

            command=new SqlCommand(query,connection);

            command.Parameters.AddWithValue("@Name", name);

            connection.Open();
            reader = command.ExecuteReader();
            bool isExist = reader.HasRows;
            connection.Close();
            return isExist;
        }

        public List<Company> GetAllCompanies()
        {
            string query = "SELECT * FROM Company";
            command=new SqlCommand(query,connection);

            List<Company> companyList = new List<Company>();
            connection.Open();

            reader = command.ExecuteReader();
            

            while (reader.Read())
            {
                Company company=new Company();

                company.Id = Convert.ToInt32(reader["Id"]);
                company.Name = reader["Name"].ToString();

                companyList.Add(company);
            }

            connection.Close();

            return companyList;

        }

        public Company GetCompanyById(int id)
        {
            string query = "SELECT * FROM Company WHERE Id =@id";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            reader = command.ExecuteReader();
            reader.Read();
            Company company = null;
            if (reader.HasRows)
            {
               company = new Company();
                company.Id = Convert.ToInt32(reader["Id"]);
                company.Name = reader["Name"].ToString();

            }
            reader.Close();
            connection.Close();
            return company;
        }

        public int UpdateById(Company company)
        {
            string query = "Update Company SET Name = @name WHERE Id = @id";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", company.Name);
            command.Parameters.AddWithValue("@id", company.Id);

            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            connection.Close();
            return rowAffect;
        }
        public int DeleteById(int id)
        {
            string query = "DELETE FROM Company WHERE Id = @id";
            command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@id",id);

            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            connection.Close();
            return rowAffect;
        }


    }
}