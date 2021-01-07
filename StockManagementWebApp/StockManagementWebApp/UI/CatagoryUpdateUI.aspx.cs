using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StockManagementWebApp.BLL;
using StockManagementWebApp.DAL.Models;

namespace StockManagementWebApp.UI
{
    public partial class CatagoryUpdateUI : System.Web.UI.Page
    {
        CategoryManager categoryManager = new CategoryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["Id"]);
                //Response.Write(id);

                Category company = categoryManager.GetCatgoryById(id);

                if (company != null)
                {
                    idHiddenField.Value = company.Id.ToString();

                    nameTextBox.Text = company.Name;

                }

            }

        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            Category aCategory = new Category();
            aCategory.Id = Convert.ToInt32(idHiddenField.Value);
            if (nameTextBox.Text!=String.Empty)
            {
                aCategory.Name = nameTextBox.Text;

                categoryManager.UpdateById(aCategory);

                Response.Redirect("CategoryUI.aspx");
       
            }
            else
            {
                outputLabel.Text = "Input Field is empty";
            }
            } 



    }
}