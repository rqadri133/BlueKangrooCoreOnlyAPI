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
                await db.AppUserRole.AddAsync(userRole);
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
                var acDel = await db.AppUserRole.FirstOrDefaultAsync(p => p.AppUserRoleId == userRoleId);
                var appUserDetailsExist = await db.AppUserRoleDetail.FirstOrDefaultAsync<AppUserRoleDetail>(p => p.AppUserRoleId == userRoleId);
                if (acDel != null && appUserDetailsExist == null)
                {
                    //Delete that post

                    var _exist = db.AppUserRoleDetail.FindAsync(userRoleId);
                    db.AppUserRole.Remove(acDel);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                else
                {
                    var error = await db.AppError.FindAsync((int)BlueKangarooErrorCode.Referential_Integrity_Code);
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
                var selUserRole = await db.AppUserRole.FirstOrDefaultAsync<AppUserRole>(p => p.AppUserRoleId == userInfo);
                if(selUserRole == null)
                {
                    var masterIdNotExist  =   await db.AppError.FindAsync((int)BlueKangarooErrorCode.ID_NOT_EXIST);
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
                var selRoles = await db.AppUserRole.ToListAsync<AppUserRole>();
                return selRoles;
            }

            return null;

           
        }

        public async Task<AppUserRole> UpdateUserRole(AppUserRole userRole)
        {
            if (db != null)
            {
                //Delete that post
                db.AppUserRole.Update(userRole);
                await db.SaveChangesAsync();
            }

            return userRole;
        }

        #region "the region here is required to separate the userrole and details this will update the bulk of role details"
        public async Task<List<AppUserRoleDetail>> UpdateUserRoleDetails(List<AppUserRoleDetail> userRoleDeatils)
        {
            if(db != null)
            {

                db.AppUserRoleDetail.UpdateRange(userRoleDeatils);
                await db.SaveChangesAsync();
            }

            return userRoleDeatils;
        }

        #endregion

        public async Task<AppUserRoleDetail> AddUserRoleDetails(AppUserRoleDetail userRoleDetail)
        {
            if (userRoleDetail != null)
            {
                // We dont have referential integrity so we must verify dependent legit ids 
                var appRoleUserId =  db.AppUserRole.FindAsync(userRoleDetail.AppUserRoleId);
                var appUITemplate = db.AppUitemplate.FindAsync(userRoleDetail.AppUitemplateId);
                if (appRoleUserId != null && appUITemplate != null )
                {
                    userRoleDetail.AppUserRoleDetailId = Guid.NewGuid();
                    userRoleDetail.CreatedDate = DateTime.Now;
                    await db.AppUserRoleDetail.AddAsync(userRoleDetail);
                    await db.SaveChangesAsync();
                }

            }
            return userRoleDetail;


        }
        public async Task<List<AppUserRoleDetail>> LoadUserRoleDetail(Guid? userRoleId)
        {

            if (db != null)
            {
                var selDetailRoles =  db.AppUserRoleDetail.Where<AppUserRoleDetail>(p => p.AppUserRoleId == userRoleId);
                if (selDetailRoles != null)
                {
                    return await selDetailRoles.ToListAsync<AppUserRoleDetail>();
                }
            }

            return null;


        }


        public async Task<List<AppUserRoleDetail>> FetchUserRoleDetailByToken(Guid? tokenId)
        {
            if(db != null)
            {
                var tokenInfo = await db.AppToken.FindAsync(tokenId);
                if( tokenInfo != null)
                {
                    var  userinfo  = await  db.AppUser.FindAsync( tokenInfo.AppTokenUserId);
                    if(userinfo != null)
                    {
                        var userRoleDetails   = db.AppUserRoleDetail.Where(p => p.AppUserRoleId == userinfo.AppRoleId);
                        if(userRoleDetails != null)
                        {
                                return await userRoleDetails.ToListAsync();

                        }
                        else
                        {
                            var errinfo = await db.AppError.FindAsync(BlueKangarooErrorCode.USER_ROLE_NOT_DEFINED);
                            throw new Exception(errinfo.AppErrorDescription + " No User role details Defined for this user " + tokenInfo.AppTokenUserId.ToString());
                        }

                    }
                    else
                    {
                        var errinfo = await db.AppError.FindAsync(BlueKangarooErrorCode.ID_NOT_EXIST);
                        throw new Exception(errinfo.AppErrorDescription + " No User ID Defined for this user " + tokenInfo.AppTokenUserId.ToString());

                    }

                }
                else
                {
                    var errinfo = await db.AppError.FindAsync(BlueKangarooErrorCode.ID_NOT_EXIST);
                    throw new Exception(errinfo.AppErrorDescription + " " + tokenId.ToString());

                }


            }

            return null;


        }

        public async Task<int> DeleteUserRoleDetail(Guid? userRoleId)
        {

            int result = 0;
            if (db != null)
            {
                // Delete all details having role id this
                var acDel =  db.AppUserRoleDetail.Where(p=> p.AppUserRoleId == userRoleId);

                if (acDel != null)
                {
                    //Delete that post
                    db.AppUserRoleDetail.RemoveRange(acDel.ToList());

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
            }
            return result;


        }
    }
}
