using BlueKangrooCoreOnlyAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace BlueKangrooCoreOnlyAPI.Repository
{
    public interface IActivityRepository
    {
        Task<AppActivity> AddActivity(AppActivity activity);
        Task<List<AppActivity>> LoadAllActivities();
        Task<int> DeleteActivityInfo(Guid? AcitivityId);
        Task<AppActivity> GetActivityInfo(Guid? activityInfo);
        Task<AppActivity> UpdateActivity(AppActivity activity);
    }
}
