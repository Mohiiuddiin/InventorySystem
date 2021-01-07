using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StockManagementWebApp.BLL;
using StockManagementWebApp.DAL.Models.ViewModels;

namespace StockManagementWebApp.UI
{
    public partial class ViewSalesBetweenTwoDatesUI : System.Web.UI.Page
    {
        SearchViewManager searchViewManager=new SearchViewManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            if (fromDateTextBox.Text!=String.Empty&& toDateTextBox.Text!=String.Empty)
            {
                string fromdate = fromDateTextBox.Text;
                string todate = toDateTextBox.Text;
                DateTime fromdatecheck = Convert.ToDateTime(fromdate);
                DateTime todatecheck = Convert.ToDateTime(todate);
                if (fromdatecheck < todatecheck)
                {
                    viewSalesGridView.DataSource = searchViewManager.GetAllSalesList(fromdate, todate);
                    viewSalesGridView.DataBind();
                    OutputLabel.Text = "Showing Result Between " + fromdate + " To " + todate;
                    viewSalesGridView.Visible = true;
                }
                else
                {
                    OutputLabel.Text = "Select Valid Date Range";
                    viewSalesGridView.Visible = false;
                }

                
            }
            else
            {
                OutputLabel.Text = "Please Choose the Date Range";
            }
        }
    
    }
}