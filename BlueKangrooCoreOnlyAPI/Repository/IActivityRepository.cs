using BlueKangrooCoreOnlyAPI.Models;
using System.Web;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;

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
