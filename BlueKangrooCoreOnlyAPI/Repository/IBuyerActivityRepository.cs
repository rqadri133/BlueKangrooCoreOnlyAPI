using BlueKangrooCoreOnlyAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace BlueKangrooCoreOnlyAPI.Repository
{
    public interface IBuyerActivityRepository
    {
        Task<AppBuyerActivity> AddBuyerActivity(AppBuyerActivity activity);
        Task<List<AppBuyerActivity>> LoadAllBuyerActivities();
        Task<int> DeleteBuyerActivityInfo(Guid? buyerAcitivityId);
        Task<AppBuyerActivity> GetBuyerActivityInfo(Guid? buyerActivityInfo);
        Task<AppBuyerActivity> UpdateBuyerActivity(AppBuyerActivity buyerActivity);
    }
}
