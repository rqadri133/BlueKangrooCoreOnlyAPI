using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlueKangrooCoreOnlyAPI.Enum;
namespace BlueKangrooCoreOnlyAPI.Repository
{
    public class TemplateUIRepository : ITemplateUIRepository
    {
        private blueKangrooContext db;
        public TemplateUIRepository(blueKangrooContext _db)
        {
            db = _db;
        }
        public async Task<AppUitemplate> AddTemplateUIInfo(AppUitemplate templateInfo)
        {
            if (db != null)
            {
                templateInfo.AppUitemplateId = Guid.NewGuid();
                templateInfo.CreatedDate = DateTime.Now;
                await db.AppUitemplates.AddAsync(templateInfo);
                await db.SaveChangesAsync();

                return templateInfo;
            }

            return templateInfo;

        }

        public  async Task<int> DeleteTemplateUIInfo(Guid? templateUid)
        {
            int result = 0;

            if (db != null)
            {
                //Find the post for specific post id
                var acTemplate = await db.AppUitemplates.FirstOrDefaultAsync(p => p.AppUitemplateId == templateUid);
                // Cannot delete if theres a dependencies defined for it
                if (acTemplate != null)
                {
                    //Delete that post
                    db.AppUitemplates.Remove(acTemplate);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;
        }
   // The role will only be assign to User
        public async Task<AppUitemplate> GetTemplateInfo(Guid? templateInfo)
        {
            if (db != null)
            {
                // One Groud Logistics per zip code
                var selTemplate = await db.AppUitemplates.FirstOrDefaultAsync<AppUitemplate>(p => p.AppUitemplateId == templateInfo);
                return selTemplate;

            }

            return null;
        }

        public async Task<List<AppUitemplate>> LoadAllUITemplates()
        {
            if (db != null)
            {

                var uiTemplates = await db.AppUitemplates.ToListAsync<AppUitemplate>();
                return uiTemplates;

            }

            return null;
        }

        public async Task<AppUitemplate> UpdateTemplateInfo(AppUitemplate templateInfo)
        {
            if (db != null)
            {
                //Delete that post
                db.AppUitemplates.Update(templateInfo);

                //Commit the transaction
                await db.SaveChangesAsync();
            }

            return templateInfo;

        }
    }

}
