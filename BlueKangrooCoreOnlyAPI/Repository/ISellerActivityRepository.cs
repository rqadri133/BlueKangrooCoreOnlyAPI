using BlueKangrooCoreOnlyAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace BlueKangrooCoreOnlyAPI.Repository
{
    public interface ISellerActivityRepository
    {
        Task<AppSellerActivity> AddSellerActivity(AppSellerActivity activity);
        Task<List<AppSellerActivity>> LoadAllSellerActivities();
        Task<int> DeleteSellerActivityInfo(Guid? sellerAcitivityId);
        Task<AppSellerActivity> GetSellerActivityInfo(Guid? sellerActivityInfo);
        Task<AppSellerActivity> UpdateSellerActivity(AppSellerActivity sellerActivity);
    }
}
