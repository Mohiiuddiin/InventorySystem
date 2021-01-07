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
    public partial class ItemUI : System.Web.UI.Page
    {
        CategoryManager categoryManager=new CategoryManager();
        CompanyManager companyManager=new CompanyManager();
        ItemManager itemManager=new ItemManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                categoryDropDownList.DataSource = categoryManager.GetAllCategories();
                categoryDropDownList.DataTextField = "Name";
                categoryDropDownList.DataValueField = "Id";
                categoryDropDownList.DataBind();
                categoryDropDownList.Items.Insert(0, new ListItem("-- Select --", "0"));
                companyDropDownList.DataSource = companyManager.GetCompanies();
                companyDropDownList.DataTextField = "Name";
                companyDropDownList.DataValueField = "Id";
                companyDropDownList.DataBind();
                companyDropDownList.Items.Insert(0, new ListItem("-- Select --", "0"));


            }
            itemGridView.DataSource = itemManager.GetAllItems();
            itemGridView.DataBind();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Item aItem = new Item();
            if (categoryDropDownList.SelectedIndex != 0 && companyDropDownList.SelectedIndex!= 0 && itemNameTextBox.Text != "" && reorderLevelTextBox.Text!=String.Empty)
            {
                aItem.CategoryId = Convert.ToInt32(categoryDropDownList.SelectedValue);
                aItem.CompanyId = Convert.ToInt32(companyDropDownList.SelectedValue);
                aItem.Name = itemNameTextBox.Text;
                aItem.ReorderLevel = Convert.ToInt32(reorderLevelTextBox.Text);
                aItem.Quantity =0;
                string message = itemManager.Save(aItem);
                outputLevel.Text = message;
                companyDropDownList.SelectedIndex = 0;
                categoryDropDownList.SelectedIndex = 0;
                itemNameTextBox.Text = String.Empty;
                reorderLevelTextBox.Text = String.Empty;
                itemGridView.DataSource = itemManager.GetAllItems();
                itemGridView.DataBind();
            }
            else
            {
                outputLevel.Text = "Fill All Data field And select Dropdown";
            }

        }

        protected void updateLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton linkButton = sender as LinkButton;
            DataControlFieldCell cell = linkButton.Parent as DataControlFieldCell;
            GridViewRow row = cell.Parent as GridViewRow;
            HiddenField hiddenField = row.FindControl("idHiddenField") as HiddenField;
            int id = Convert.ToInt32(hiddenField.Value);
            Response.Redirect("ItemUpdateUI.aspx?id= "+id);
            //Response.Write(hiddenField.Value);

        }
        protected void deleteLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton linkButton = sender as LinkButton;
            DataControlFieldCell cell = linkButton.Parent as DataControlFieldCell;
            GridViewRow row = cell.Parent as GridViewRow;
            HiddenField hiddenField = row.FindControl("idHiddenField") as HiddenField;
            int id = Convert.ToInt32(hiddenField.Value);
            itemManager.DeleteById(id);
            itemGridView.DataSource = itemManager.GetAllItems();
            itemGridView.DataBind();
            //Response.Write(hiddenField.Value);

        }

       
    }
}