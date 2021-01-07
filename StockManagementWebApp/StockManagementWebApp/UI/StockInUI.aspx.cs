using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StockManagementWebApp.BLL;
using StockManagementWebApp.DAL.Models;
using StockManagementWebApp.DAL.Models.ViewModels;

namespace StockManagementWebApp.UI
{
    public partial class StockInUI : System.Web.UI.Page
    {
        CompanyManager companyManager=new CompanyManager();
        ItemManager itemManager=new ItemManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               CompanyBind();
                

            }

            
        }

        public void CompanyBind()
        {
            companyDropDownList.DataSource = companyManager.GetCompanies();
            companyDropDownList.DataTextField = "Name";
            companyDropDownList.DataValueField = "Id";
            companyDropDownList.DataBind();
            companyDropDownList.Items.Insert(0, new ListItem("-- Select --", "0"));
       
        }

        protected void itemDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (companyDropDownList.SelectedIndex == 0)
            {
                reorderLevelTextBox.Text = "0";
                availabelQuantityTextBox.Text = "0";
            }

            else
            {
                int id = Convert.ToInt32(itemDropDownList.SelectedValue);
                if (id > 0)
                {
                    ItemViewModel item = new ItemViewModel();
                    item = itemManager.GetItemById(id);
                    reorderLevelTextBox.Text = item.ReorderLevel.ToString();
                    availabelQuantityTextBox.Text = item.Quantity.ToString();

                }
            }
        }
        protected void CompanyValueSelectedIndexChanged(object sender, EventArgs e)
       {
           
           int companyid = Convert.ToInt32(companyDropDownList.SelectedValue);
           itemDropDownList.DataSource = itemManager.GetAllItemsByCompany(companyid);
           itemDropDownList.DataTextField = "ItemName";
           itemDropDownList.DataValueField = "ItemId";
           itemDropDownList.DataBind();
           itemDropDownList.Items.Insert(0, new ListItem("-- Select --", "0"));

  }

     
        protected void saveButton_Click(object sender, EventArgs e)
        {
            ItemViewModel itemViewModel=new ItemViewModel();
          //  itemViewModel.CompanyId = Convert.ToInt32(companyDropDownList.DataValueField);
            if (itemDropDownList.SelectedIndex != 0 && companyDropDownList.SelectedIndex != 0 &&
                stockInquantityTextBox.Text != String.Empty)
            {
                itemViewModel.ItemId = Convert.ToInt32(itemDropDownList.SelectedValue);
                itemViewModel.Quantity = Convert.ToInt32(stockInquantityTextBox.Text);
                string message = itemManager.UpdateById(itemViewModel);
                outputLabel.Text = message;
            }
            else
            
            {
                outputLabel.Text = "Fill All Data field And select Dropdown";
            } 

         }
   }

       
 }
