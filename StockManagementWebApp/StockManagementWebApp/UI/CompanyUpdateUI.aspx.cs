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
    public partial class CompanyUpdateUI : System.Web.UI.Page
    {
        CompanyManager companyManager = new CompanyManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["Id"]);
                //Response.Write(id);

                Company company = companyManager.GetCompanyById(id);

                if (company != null)
                {
                    idHiddenField.Value = company.Id.ToString();

                    nameTextBox.Text = company.Name;

                }

            }
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            Company acompany = new Company();
            acompany.Id = Convert.ToInt32(idHiddenField.Value);
            if (nameTextBox.Text != String.Empty)
            {
                acompany.Name = nameTextBox.Text;

                companyManager.UpdateById(acompany);
                Response.Redirect("CompanyUI.aspx");
            }
            else
            {
                outputLabel.Text = "Input Company Name";
            }
        }


    }
}