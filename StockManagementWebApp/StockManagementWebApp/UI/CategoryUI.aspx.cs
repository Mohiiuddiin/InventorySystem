using System;
using System.Web.UI.WebControls;
using StockManagementWebApp.BLL;

namespace StockManagementWebApp.UI
{
    public partial class CategoryUI : System.Web.UI.Page
    {
        CategoryManager catManager=new CategoryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            categoryGridView.DataSource = catManager.GetAllCategories();
            categoryGridView.DataBind();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Category aCategory = new Category();
            if (nameTextBox.Text != String.Empty)
            {
                aCategory.Name = nameTextBox.Text;

                string message = catManager.Save(aCategory);

                outputLabel.Text = message;

                if (message == "save successfuly")
                {
                    nameTextBox.Text = "";
                }

                categoryGridView.DataSource = catManager.GetAllCategories();
                categoryGridView.DataBind();
            }
            else
            {
                outputLabel.Text = "Input Catagory Name";
            }


        }
    

        protected void updateLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton linkButton = sender as LinkButton;
            DataControlFieldCell cell = linkButton.Parent as DataControlFieldCell;
            GridViewRow row = cell.Parent as GridViewRow;
            HiddenField hiddenField = row.FindControl("idHiddenField") as HiddenField;
            int id = Convert.ToInt32(hiddenField.Value);
            Response.Redirect( "CatagoryUpdateUI.aspx?id= " +id);
            //Response.Write(hiddenField.Value);
            
        }

        protected void deleteLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton linkButton = sender as LinkButton;
            DataControlFieldCell cell = linkButton.Parent as DataControlFieldCell;
            GridViewRow row = cell.Parent as GridViewRow;
            HiddenField hiddenField = row.FindControl("idHiddenField") as HiddenField;
            int id = Convert.ToInt32(hiddenField.Value);
            catManager.DeleteById(id);
            categoryGridView.DataSource = catManager.GetAllCategories();
            categoryGridView.DataBind();
            //Response.Write(hiddenField.Value);

        }
    }
}