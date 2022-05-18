using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueKangrooCoreOnlyAPI.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private blueKangrooContext db;
        public CompanyRepository(blueKangrooContext _db)
        {




            db = _db;
        }
        public async Task<AppCompany> AddCompany(AppCompany company)
        {
            if (db != null)
            {
                company.AppCompanyId = Guid.NewGuid();
                company.CreatedDate = DateTime.Now;
                await db.AppCompany.AddAsync(company);
                await db.SaveChangesAsync();

                return company;
            }

            return company;


        }
        public async Task<List<AppCompany>> LoadAllCompanies()
        {
            if (db != null)
            {

                var companies = await db.AppCompany.ToListAsync<AppCompany>();
                return companies;

            }

            return null;


        }
        public async Task<int> DeleteCompanyInfo(Guid? CompanyId)
        {
            int result = 0;

            if (db != null)
            {
                //Find the post for specific post id
                var acDel = await db.AppCompany.FirstOrDefaultAsync(p => p.AppCompanyId == CompanyId);

                if (acDel != null)
                {
                    //Delete that post
                    db.AppCompany.Remove(acDel);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;


        }

        public async Task<AppCompany> GetCompanyInfo(Guid? companyInfo)
        {
            if (db != null)
            {
                // One Groud Logistics per zip code
                var selCompany = await db.AppCompany.FirstOrDefaultAsync<AppCompany>(p => p.AppCompanyId == companyInfo);
                return selCompany;

            }

            return null;
        }

        public async Task<AppCompany> UpdateCompany(AppCompany company)
        {
            if (db != null)
            {
                //Delete that post
                db.AppCompany.Update(company);

                //Commit the transaction
                await db.SaveChangesAsync();
            }

            return company;

        }

    }
}


