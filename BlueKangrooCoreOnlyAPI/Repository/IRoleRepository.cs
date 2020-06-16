using BlueKangrooCoreOnlyAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace BlueKangrooCoreOnlyAPI.Repository
{
    public interface IRoleRepository
    {
        Task<AppUserRole> AddUserRole(AppUserRole userRole);
        Task<List<AppUserRole>> LoadAppUserRole();
        Task<int> DeleteAppUserRoleInfo(Guid? userRoleId);
        Task<AppUserRole> GetUserRoleInfo(Guid? userInfo);
        Task<AppUserRole> UpdateUserRole(AppUserRole userRole);
        Task<AppUserRoleDetail> AddUserRoleDetails(AppUserRoleDetail userRole);
        Task<List<AppUserRoleDetail>> LoadUserRoleDetail(Guid? userRoleId);
        Task<List<AppUserRoleDetail>> FetchUserRoleDetailByToken(Guid? tokenId);

        Task<int> DeleteUserRoleDetail(Guid? userRoleId);
        Task<List<AppUserRoleDetail>> UpdateUserRoleDetails(List<AppUserRoleDetail> userRoleDetails);



    }
}
