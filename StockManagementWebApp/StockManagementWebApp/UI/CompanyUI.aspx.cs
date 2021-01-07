using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StockManagementWebApp.BLL;
using StockManagementWebApp.DAL.Models;
using StockManagementWebApp.UI;

namespace StockManagementWebApp
{
    public partial class CompanyUI : System.Web.UI.Page
    {
        CompanyManager companyManager=new CompanyManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            companyGridView.DataSource = companyManager.GetCompanies();
            companyGridView.DataBind();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Company aCompany=new Company();
            if (nameTextBox.Text != String.Empty)
            {
                aCompany.Name = nameTextBox.Text;
                string message = companyManager.Save(aCompany);
                outputLabel.Text = message;

                if (message == "save successfuly")
                {
                    nameTextBox.Text = "";
                }
                companyGridView.DataSource = companyManager.GetCompanies();
                companyGridView.DataBind();
      
            }
            else
            {
                outputLabel.Text = "Input Company Name";
            }
             }

        protected void updateLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton linkButton = sender as LinkButton;
            DataControlFieldCell cell = linkButton.Parent as DataControlFieldCell;
            GridViewRow row = cell.Parent as GridViewRow;
            HiddenField hiddenField = row.FindControl("idHiddenField") as HiddenField;
            int id = Convert.ToInt32(hiddenField.Value);
            Response.Redirect("CompanyUpdateUI.aspx?Id= "+id);
            //Response.Write(hiddenField.Value);

        }
        protected void deleteLinkButton_Click (object sender, EventArgs e)
        {
            LinkButton linkButton = sender as LinkButton;
            DataControlFieldCell cell = linkButton.Parent as DataControlFieldCell;
            GridViewRow row = cell.Parent as GridViewRow;
            HiddenField hiddenField = row.FindControl("idHiddenField") as HiddenField;
            int id = Convert.ToInt32(hiddenField.Value);
            companyManager.DeleteById(id);
            companyGridView.DataSource = companyManager.GetCompanies();
            companyGridView.DataBind();
            //Response.Write(hiddenField.Value);

        }
    }
}