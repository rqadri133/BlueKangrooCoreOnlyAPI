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
                await db.AppUitemplate.AddAsync(templateInfo);
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
                var acTemplate = await db.AppUitemplate.FirstOrDefaultAsync(p => p.AppUitemplateId == templateUid);
                // Cannot delete if theres a dependencies defined for it
                var roleDetails = await db.AppUserRoleDetail.FirstOrDefaultAsync(p => p.AppUitemplateId == templateUid);
                if (acTemplate != null && roleDetails == null)
                {
                    //Delete that post
                    db.AppUitemplate.Remove(acTemplate);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                else if(roleDetails != null )
                {
                    var error  = await db.AppError.FindAsync((int)BlueKangarooErrorCode.Referential_Integrity_Code);
                    // this error should be populated from external services with error code
                    throw new Exception(error.AppErrorDescription);
                }
                else
                {
                    var error = await db.AppError.FindAsync((int)BlueKangarooErrorCode.ID_NOT_EXIST);
                    // this error should be populated from external services with error code
                    throw new Exception(error.AppErrorDescription);

                }
                return result;
            }

            return result;
        }

        public async Task<AppUitemplate> GetTemplateInfo(Guid? templateInfo)
        {
            if (db != null)
            {
                // One Groud Logistics per zip code
                var selTemplate = await db.AppUitemplate.FirstOrDefaultAsync<AppUitemplate>(p => p.AppUitemplateId == templateInfo);
                return selTemplate;

            }

            return null;
        }

        public async Task<List<AppUitemplate>> LoadAllUITemplates()
        {
            if (db != null)
            {

                var uiTemplates = await db.AppUitemplate.ToListAsync<AppUitemplate>();
                return uiTemplates;

            }

            return null;
        }

        public async Task<AppUitemplate> UpdateTemplateInfo(AppUitemplate templateInfo)
        {
            if (db != null)
            {
                //Delete that post
                db.AppUitemplate.Update(templateInfo);

                //Commit the transaction
                await db.SaveChangesAsync();
            }

            return templateInfo;

        }
    }

}
