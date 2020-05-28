using BlueKangrooCoreOnlyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueKangrooCoreOnlyAPI.Repository
{
    public interface ICompanyRepository
    {
        Task<AppCompany> AddCompany(AppCompany company);
        Task<List<AppCompany>> LoadAllCompanies();
        Task<int> DeleteCompanyInfo(Guid? CompanyId);
        Task<AppCompany> GetCompanyInfo(Guid? activityInfo);
        Task<AppCompany> UpdateCompany(AppActivity activity);
    }
}


