using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StockManagementWebApp.DAL.Models;

namespace StockManagementWebApp.DAL.Gateway
{
    public class StockoutGateway : BaseGateway
    {
        public int UpdateById(Stockout stockout)
        {
            string query = "Update Items SET Quantity =Quantity- @quantity WHERE Id = @id";
            command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", stockout.ItemId);
            command.Parameters.AddWithValue("@quantity", stockout.Quantity);

            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            connection.Close();
            return rowAffect;
        }
        public int save(Stockout stockout)
        {
            string query = "INSERT INTO StockOut(ItemId,Quantity,Action,Date) VALUES(@itemid,@quantity,@action,@date)";
            command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@itemid",stockout.ItemId );
            command.Parameters.AddWithValue("@quantity", stockout.Quantity);
            command.Parameters.AddWithValue("@action", stockout.Action);
            command.Parameters.AddWithValue("@date", stockout.Date);


            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            connection.Close();
            return rowAffect;

        }
    }
}