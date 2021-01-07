using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StockManagementWebApp.BLL;
using StockManagementWebApp.DAL.Models;
using StockManagementWebApp.DAL.Models.ViewModels;

namespace StockManagementWebApp.UI
{
    [Serializable]
    public partial class StockoutUI : System.Web.UI.Page
    {
        
        CompanyManager companyManager = new CompanyManager();
        ItemManager itemManager = new ItemManager();
        StockoutManager stockoutManager=new StockoutManager();
        List<Stockout> data = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            data = ViewState["dataVS"] as List<Stockout>;
            if (data == null)
            {
                data = new List<Stockout>();
                ViewState["dataVS"] = data;
            }
           

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

        protected void addButton_Click(object sender, EventArgs e)
        {
            Stockout itemStockout=new Stockout();
            if (itemDropDownList.SelectedIndex != 0 && companyDropDownList.SelectedIndex != 0 &&
                stockOutquantityTextBox.Text != String.Empty)
            {
                if (Convert.ToInt32(stockOutquantityTextBox.Text) > 0)
                {
                    itemStockout.ItemId = Convert.ToInt32(itemDropDownList.SelectedValue);
                    itemStockout.ItemName = itemDropDownList.SelectedItem.Text;
                    itemStockout.CompanyName = companyDropDownList.SelectedItem.Text;
                    itemStockout.Quantity = Convert.ToInt32(stockOutquantityTextBox.Text);
                    foreach (Stockout stockout in data)
                    {
                        if (stockout.ItemId == itemStockout.ItemId)
                        {
                            stockout.Quantity += itemStockout.Quantity;
                            stockoutItemsGridview.DataSource = data;
                            stockoutItemsGridview.DataBind();
                            return;
                        }
                    }
                    data.Add(itemStockout);
                    stockoutItemsGridview.DataSource = data;
                    stockoutItemsGridview.DataBind();
           
                }
                else
                {
                    outputLabel.Text = "Please Input Positive Quantity Value";
                }

             }
            else
            {
                outputLabel.Text = "Fill All Data field And select Dropdown";
            }
  }
        
        protected void sellButton_Click(object sender, EventArgs e)
        {
            foreach (Stockout stockoutItem in data)
            {
                DateTime d = DateTime.Today;

                String date = d.ToString("yyyy/MM/dd hh:mm:ss tt", CultureInfo.InvariantCulture);


                stockoutItem.Date = date;

                stockoutItem.Action = "SELL";
               
                string message=stockoutManager.save(stockoutItem);
                stockoutManager.UpdateById(stockoutItem);
                companyDropDownList.SelectedIndex = 0;
                itemDropDownList.SelectedIndex = 0;
                stockoutItemsGridview.Visible = false;
                reorderLevelTextBox.Text=String.Empty;
                availabelQuantityTextBox.Text=String.Empty;
                stockOutquantityTextBox.Text=String.Empty;
                outputLabel.Text = message;

            }
        }

        protected void damageButton_Click(object sender, EventArgs e)
        {
            foreach (Stockout stockoutItem in data)
            {
                DateTime d = DateTime.Today;

                String date = d.ToString("yyyy/MM/dd hh:mm:ss tt", CultureInfo.InvariantCulture);


                stockoutItem.Date = date;

                stockoutItem.Action = "DAMAGE";

                string message = stockoutManager.save(stockoutItem);
                stockoutManager.UpdateById(stockoutItem);
                companyDropDownList.SelectedIndex = 0;
                itemDropDownList.SelectedIndex = 0;
                stockoutItemsGridview.Visible = false;
                reorderLevelTextBox.Text = String.Empty;
                availabelQuantityTextBox.Text = String.Empty;
                stockOutquantityTextBox.Text = String.Empty;
                outputLabel.Text = message;
            }

        }

        protected void lostButton_Click(object sender, EventArgs e)
        {
            foreach (Stockout stockoutItem in data)
            {
                DateTime d = DateTime.Today;

                String date = d.ToString("yyyy/MM/dd hh:mm:ss tt", CultureInfo.InvariantCulture);


                stockoutItem.Date = date;

                stockoutItem.Action = "LOST";

              string message=  stockoutManager.save(stockoutItem);
                stockoutManager.UpdateById(stockoutItem);
                companyDropDownList.SelectedIndex = 0;
                itemDropDownList.SelectedIndex = 0;
                stockoutItemsGridview.Visible = false;
                reorderLevelTextBox.Text = String.Empty;
                availabelQuantityTextBox.Text = String.Empty;
                stockOutquantityTextBox.Text = String.Empty;
                outputLabel.Text = "Item Added to Lostlist";
                outputLabel.Text = message;
            }
        }

       
    }
}