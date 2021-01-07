using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StockManagementWebApp.DAL.Gateway;
using StockManagementWebApp.DAL.Models;

namespace StockManagementWebApp.BLL
{
    public class CompanyManager
    {
        CompanyGateway companyGateway=new CompanyGateway();

        public string Save(Company company)
        {
            if (companyGateway.IsExistCategoryName(company.Name))
            {
                return "Company Name Is Already Exist";
            }
            else
            {
                int rowAffect = companyGateway.save(company);
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

        public List<Company> GetCompanies()
        {
            return companyGateway.GetAllCompanies();
        }

        public Company GetCompanyById(int id)
        {
            return companyGateway.GetCompanyById(id);
        }

        public string UpdateById(Company company)
        {
            int rowAffect=companyGateway.UpdateById(company);
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
            int rowAffect=companyGateway.DeleteById(id);
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