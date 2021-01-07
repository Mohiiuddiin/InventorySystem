using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StockManagementWebApp.BLL;

namespace StockManagementWebApp.UI
{
    public partial class SearchAndViewItemsUI : System.Web.UI.Page
    {
        CompanyManager companyManager = new CompanyManager();
        CategoryManager categoryManager=new CategoryManager();
        ItemManager itemManager = new ItemManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                companyDropdownList.DataSource = companyManager.GetCompanies();
                companyDropdownList.DataTextField = "Name";
                companyDropdownList.DataValueField = "Id";
                companyDropdownList.DataBind();
                companyDropdownList.Items.Insert(0, new ListItem("-- Select --", "0"));

                categoryDropdownList.DataSource = categoryManager.GetAllCategories();
                categoryDropdownList.DataTextField = "Name";
                categoryDropdownList.DataValueField = "Id";
                categoryDropdownList.DataBind();
                categoryDropdownList.Items.Insert(0, new ListItem("-- Select --", "0"));

            }
            

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            int companyIndex = companyDropdownList.SelectedIndex;
            int categoryIndex = categoryDropdownList.SelectedIndex;
            int companyId = Convert.ToInt32(companyDropdownList.SelectedValue);
            int categoryId = Convert.ToInt32(categoryDropdownList.SelectedValue);

              if (companyIndex == 0 && categoryIndex == 0)
            {
                itemsGridView.DataSource = itemManager.GetAllItems();
                itemsGridView.DataBind();
            }

              else if (companyIndex != 0 && categoryIndex == 0)
              {
                  itemsGridView.DataSource = itemManager.GetAllItemsByCompany(companyId);
                  itemsGridView.DataBind();
              }

            else if (companyIndex == 0 && categoryIndex != 0)
            {
               itemsGridView.DataSource= itemManager.GetAllItemsByCategory(categoryId);
                itemsGridView.DataBind();

            }

              else if (companyIndex != 0 && categoryIndex != 0)
              {
                  itemsGridView.DataSource = itemManager.GetAllItemsByCompanyAndCategory(companyId,categoryId);
                  itemsGridView.DataBind();

              }
           
           
            
        }
    }
}