using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Google.Rpc;
using BlueKangrooCoreOnlyAPI.Enum;
namespace BlueKangrooCoreOnlyAPI.Repository
{
    public class RoleRepository : IRoleRepository
    {

        private blueKangrooContext db;
        public RoleRepository(blueKangrooContext _db)
        {
            db = _db;
        }

        
        public async Task<AppUserRole> AddUserRole(AppUserRole userRole)
        {
            if (userRole != null)
            {
                userRole.AppUserRoleId = Guid.NewGuid();
                userRole.CreatedDate = DateTime.Now;
                await db.AppUserRoles.AddAsync(userRole);
                await db.SaveChangesAsync();


            }
            return userRole;


        }

        public async Task<int> DeleteAppUserRoleInfo(Guid? userRoleId)
        {
            int result = 0;
            if (db != null)
            {
                //Find the post for specific post id
                var acDel = await db.AppUserRoles.FirstOrDefaultAsync(p => p.AppUserRoleId == userRoleId);
                if (acDel != null )
                {
                    //Delete that post

                    var _exist = db.AppUserRoles.FindAsync(userRoleId);
                    db.AppUserRoles.Remove(acDel);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                else
                {
                    var error = await db.AppErrors.FindAsync((int)BlueKangarooErrorCode.Referential_Integrity_Code);
                    throw new Exception(error.AppErrorDescription);
                }
              
            }
            return result;

        }

        
        
        public async Task<AppUserRole> GetUserRoleInfo(Guid? userInfo)
        {
            if (db != null)
            {
                // One Groud Logistics per zip code
                var selUserRole = await db.AppUserRoles.FirstOrDefaultAsync<AppUserRole>(p => p.AppUserRoleId == userInfo);
                if(selUserRole == null)
                {
                    var masterIdNotExist  =   await db.AppErrors.FindAsync((int)BlueKangarooErrorCode.ID_NOT_EXIST);
                    throw new Exception(masterIdNotExist.AppErrorDescription); 

                }

                return selUserRole;

            }

            return null;
        }

        public async Task<List<AppUserRole>> LoadAppUserRole()
        {
            if(db != null)
            {
                var selRoles = await db.AppUserRoles.ToListAsync<AppUserRole>();
                return selRoles;
            }

            return null;

           
        }

        public async Task<AppUserRole> UpdateUserRole(AppUserRole userRole)
        {
            if (db != null)
            {
                //Delete that post
                db.AppUserRoles.Update(userRole);
                await db.SaveChangesAsync();
            }

            return userRole;
        }

     

        public async Task<int> DeleteUserRoleDetail(Guid? userRoleId)
        {

            int result = 0;
            if (db != null)
            {
                // Delete all details having role id this
                var acDel =  db.AppUserRoles.Where(p=> p.AppUserRoleId == userRoleId);

                if (acDel != null)
                {
                    //Delete that post
                    db.AppUserRoles.RemoveRange(acDel.ToList());

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
            }
            return result;


        }
    }
}
