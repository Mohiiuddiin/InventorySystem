using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StockManagementWebApp.DAL.Gateway;

namespace StockManagementWebApp.BLL
{
    public class CategoryManager
    {
        private CategoryGateway catGateway = new CategoryGateway();

        public string Save(Category category)
        {
            if (catGateway.IsExistCategoryName(category.Name))
            {
                return "Category Name Is Already Exist";
            }
            else
            {
                int rowAffect = catGateway.save(category);
                if (rowAffect > 0)
                {
                    return "save successfuly";
                }
                else
                {
                    return "Save Failed";
                }
            }
        }

        public List<Category> GetAllCategories()
        {
            return catGateway.GetAllCategories();
        }

        public Category GetCatgoryById(int id)
        {
            return catGateway.GetCategoryById(id);
        }

        public string UpdateById(Category category)
        {
            int rowAffect = catGateway.UpdateById(category);
            if (rowAffect > 0)
            {
                return "Update successfuly";
            }
            else
            {
                return "Update Failed";
            }
        }

        public string DeleteById(int id)
        {
            int rowAffect = catGateway.DeleteById(id);
            if (rowAffect > 0)
            {
                return "Delete successfuly";
            }
            else
            {
                return "Delete Failed";
            }
        }
    }
}