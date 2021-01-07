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
    public partial class ItemUpdateUI : System.Web.UI.Page
    {
        ItemManager itemManager=new ItemManager();
        CompanyManager companyManager=new CompanyManager();
        CategoryManager categoryManager=new CategoryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                int id = Convert.ToInt32(Request.QueryString["Id"]);
                //Response.Write(id);

                Item item = itemManager.GetItemByItemId(id);
                categoryDropDownList.DataSource = categoryManager.GetAllCategories();
                categoryDropDownList.DataTextField = "Name";
                categoryDropDownList.DataValueField = "Id";
                categoryDropDownList.DataBind();
                
                companyDropDownList.DataSource=companyManager.GetCompanies();
                companyDropDownList.DataTextField = "Name";
                companyDropDownList.DataValueField = "Id";
                companyDropDownList.DataBind();
                

                if (item != null)
                {
                   // idHiddenField.Value = item.Id.ToString();
                    categoryDropDownList.SelectedValue= item.CategoryId.ToString();
                    companyDropDownList.SelectedValue = item.CompanyId.ToString();
                    itemNameTextBox.Text = item.Name;
                    reorderLevelTextBox.Text = item.ReorderLevel.ToString();

                }

            }
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
          Item aItem =new Item();
            if (itemNameTextBox.Text!=String.Empty && reorderLevelTextBox.Text!=String.Empty && Convert.ToInt32(reorderLevelTextBox.Text)>0)
            {
                aItem.Id = Convert.ToInt32(Request.QueryString["Id"]);
                aItem.CategoryId = Convert.ToInt32(categoryDropDownList.SelectedValue);
                aItem.CompanyId = Convert.ToInt32(companyDropDownList.SelectedValue);
                aItem.Name = itemNameTextBox.Text;
                aItem.ReorderLevel = Convert.ToInt32(reorderLevelTextBox.Text);
                itemManager.UpdateByItemId(aItem);
     
                    Response.Redirect("ItemUI.aspx");
   
            }
            else
            {
                outputLabel.Text = "Please Input Values in Datainput Fields Or may input negative value in reroder level ";
            }

        }
       

    }
}